using System.Globalization;
using System.IO.Ports;
using System.Media;

namespace ZOYI
{
    public partial class MainWindow : Form
    {
        public enum PARSE_MODE
        {
            STD,
            EXT,
            LUA,
            RAW
        }

        FrameDecoder frame_dec;

        COMx comx;
        StandardDisplayPanel standardDisplayPanel;
        AdancedDisplayPanel advancedDisplayPanel;

        MLua mLua;
        string luaPath = "FrameDecoder\\parse_std.lua";
        Tools tools;
        string toolsPath = "Tools\\Tools.txt";

        /*
         * Move window section
         */
        bool bMouseDown = false;
        Point mousePosDown = Point.Empty;
        Point currentFormLocation = Point.Empty;

        /*
         * Alarm section
         */
        bool bAlarmEnable = false;
        float fAlarmOverValue = 0.0f;
        float fAlarmUnderValue = 0.0f;
        Thread alarmSoundThread;
        bool bBeepPlaying = false;

        public MainWindow()
        {
            InitializeComponent();
            this.Location = new Point(Properties.Settings.Default.main_form_pos_x,
                Properties.Settings.Default.main_form_pos_y);

            standardDisplayPanel = new StandardDisplayPanel(chbStandardPanel);
            standardDisplayPanel.Show();

            advancedDisplayPanel = new AdancedDisplayPanel(chbAdvancedPanel);
            advancedDisplayPanel.Show();

            Directory.CreateDirectory("logs");
            cbAlarmLabel.SelectedItem = "Voltage";

            frame_dec = new FrameDecoder();

            comx = new COMx();

            tools = new Tools(toolsPath, panelTools);
            tools.refreshTools();

            refreshCOMlist();

            tbarArcTicks.Value = Properties.Settings.Default.panel_adv_ticks;
            lblArcTicks.Text = tbarArcTicks.Value.ToString();
            tbarThicksCount.Value = Properties.Settings.Default.panel_adv_thicks_count;
            lblThicksCount.Text = tbarThicksCount.Value.ToString();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //bCOMconnected = false;
            comx.disconnect();
            standardDisplayPanel.Close();

            Properties.Settings.Default.main_form_pos_x = this.Location.X;
            Properties.Settings.Default.main_form_pos_y = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void chbShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbStandardPanel.Checked)
            {
                standardDisplayPanel.Show();
            }
            else
            {
                standardDisplayPanel.Hide();
            }
        }

        private void chbAdvancedPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAdvancedPanel.Checked)
            {
                advancedDisplayPanel.Show();
            }
            else
            {
                advancedDisplayPanel.Hide();
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            tbComOutput.Text = "";
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            File.WriteAllText("logs\\" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log", tbComOutput.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            standardDisplayPanel.Close();
            advancedDisplayPanel.Close();
            System.Windows.Forms.Application.Exit();
        }

        /*
         * 
         * Move window section
         * 
         */
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            mousePosDown = Control.MousePosition;
            currentFormLocation = Location;
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
            mousePosDown = Point.Empty;
            currentFormLocation = Point.Empty;
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                var currentPos = Control.MousePosition;
                var distX = currentPos.X - mousePosDown.X;
                var distY = currentPos.Y - mousePosDown.Y;
                Location = new Point(currentFormLocation.X + distX, currentFormLocation.Y + distY);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
         * 
         * Colors section
         * 
         */

        private void btnColorBg_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;

            if (cd.ShowDialog() == DialogResult.OK)
                standardDisplayPanel.setBackgroundColor(cd.Color);
        }

        private void btnColorLabel_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;

            if (cd.ShowDialog() == DialogResult.OK)
                standardDisplayPanel.setLabelFontColor(cd.Color);
        }

        private void btnColorValue_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;

            if (cd.ShowDialog() == DialogResult.OK)
                standardDisplayPanel.setValueFontColor(cd.Color);
        }

        /*
         * 
         * Alarm section
         * 
         */
        private void chbAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAlarm.Checked)
            {
                plAlarm.Enabled = false;
                bAlarmEnable = true;
                //float.TryParse(tbAlarmOverValue.Text.Replace('.', ','), out fAlarmOverValue);
                //float.TryParse(tbAlarmUnderValue.Text.Replace('.', ','), out fAlarmUnderValue);
                fAlarmOverValue = float.Parse(tbAlarmOverValue.Text.Replace('.', ','), CultureInfo.InvariantCulture.NumberFormat);
                fAlarmUnderValue = float.Parse(tbAlarmUnderValue.Text.Replace('.', ','), CultureInfo.InvariantCulture.NumberFormat);
            }
            else
            {
                plAlarm.Enabled = true;
                bAlarmEnable = false;
            }
        }

        private void alarmProcess(string label, string value)
        {
            if (!bBeepPlaying)
            {
                try
                {
                    // must break if fail - don't use TryParse
                    float val = float.Parse(value.Replace('.', ','));
                    //float val = float.Parse(value.Replace('.', ','), CultureInfo.InvariantCulture.NumberFormat);

                    bool bOverThreshold = (cbValueOver.Checked && (val > fAlarmOverValue));
                    bool bUnderThreshold = (cbValueUnder.Checked && (val < fAlarmUnderValue));

                    if (bOverThreshold || bUnderThreshold)
                    {
                        bBeepPlaying = true;
                        alarmSoundThread = new Thread(new ThreadStart(playAlarmBeepThread));
                        alarmSoundThread.Start();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void playAlarmBeepThread()
        {
            SoundPlayer snd = new SoundPlayer("Sounds\\beep.wav");
            snd.PlaySync();
            bBeepPlaying = false;
        }

        private void tbPanelOpacity_Scroll(object sender, EventArgs e)
        {
            standardDisplayPanel.changeOpacity(tbarPanelOpacity.Value);
        }

        /*
         * Tools
         */
        private async void btnToolsEdit_Click(object sender, EventArgs e)
        {
            RichEditor re = new RichEditor(tools);
            re.loadFile(toolsPath, RichEditor.ENCODING.TOOLS);

            string result = await re.AsyncEdit();

            if (result == "save")
                tools.refreshTools();
        }

        private void btnToolsRefresh_Click(object sender, EventArgs e)
        {
            tools.refreshTools();
        }

        private void tbarArcTicks_Scroll(object sender, EventArgs e)
        {
            if (tbarArcTicks.Value < tbarThicksCount.Value)
            {
                tbarThicksCount.Value = tbarArcTicks.Value;
                lblThicksCount.Text = tbarThicksCount.Value.ToString();
                advancedDisplayPanel.setArcProgressBarThicksCount(tbarThicksCount.Value);
            }

            advancedDisplayPanel.setArcProgressBarTicks(tbarArcTicks.Value);
            lblArcTicks.Text = tbarArcTicks.Value.ToString();
        }

        private void tbarThicksCount_Scroll(object sender, EventArgs e)
        {
            if (tbarThicksCount.Value > tbarArcTicks.Value)
            {
                tbarArcTicks.Value = tbarThicksCount.Value;
                lblArcTicks.Text = tbarArcTicks.Value.ToString();
                advancedDisplayPanel.setArcProgressBarTicks(tbarArcTicks.Value);
            }

            advancedDisplayPanel.setArcProgressBarThicksCount(tbarThicksCount.Value);
            lblThicksCount.Text = tbarThicksCount.Value.ToString();
        }
    }
}
