using System.Globalization;
using System.IO.Ports;
using System.Media;
using ZOYIv2;

namespace ZOYI
{
    public partial class MainWindow : Form
    {
        public enum PARSE_MODE
        {
            STD,
            LUA,
            RAW
        }

        LabelValueSuffix lvs;

        COMx comx;
        StandardDisplayPanel standardDisplayPanel;
        AdancedDisplayPanel advancedDisplayPanel;

        MLua mLua;
        string luaPath = "MLua\\parse.lua";
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

            standardDisplayPanel = new StandardDisplayPanel();
            //displayPanel.StartPosition = FormStartPosition.CenterParent;
            standardDisplayPanel.Show();

            advancedDisplayPanel = new AdancedDisplayPanel();
            advancedDisplayPanel.Show();

            Directory.CreateDirectory("logs");
            cbAlarmLabel.SelectedItem = "Voltage";

            lvs = new LabelValueSuffix();

            comx = new COMx();
            mLua = new MLua();

            tools = new Tools(toolsPath, panelTools);
            tools.refreshTools();

            refreshCOMlist();
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

        /*
         * 
         * Parse data from COM port
         * 
         */
        string[] parseLabelValueSuffix_STD(string buff)
        {
            string[] label_value = buff.Split(':');
            // label, value, suffix
            string[] ret = new string[3];
            ret[1] = label_value[1];

            switch (label_value[0])
            {
                case "Electricity":
                    ret[0] = "Ampery";
                    ret[2] += "A";
                    break;
                case "AElectricity":
                    ret[0] = "Ampery";
                    ret[2] = "A";
                    break;
                case "mAElectricity":
                    ret[0] = "Ampery";
                    ret[2] = "mA";
                    break;
                case "MOMResistance":
                    ret[0] = "Rezystancja";
                    ret[2] = "MΩ";
                    break;
                case "OMResistance":
                    ret[0] = "Rezystancja";
                    ret[2] = "Ω";
                    break;
                case "KOMResistance":
                    ret[0] = "Rezystancja";
                    ret[2] = "KΩ";
                    break;
                case "OMbeep":
                    ret[0] = "Buzzer";
                    ret[2] = "";
                    break;
                case "VDiode":
                    ret[0] = "Tryb diody";
                    ret[2] = "mV";
                    if (!ret[1].Contains("0,"))
                        ret[2] = "V";
                    break;
                case "nFCap":
                    ret[0] = "Pojemność nF";
                    ret[2] = "nF";
                    break;
                case "uFCap":
                    ret[0] = "Pojemność uF";
                    ret[2] = "uF";
                    break;
                case "mFCap":
                    ret[0] = "Pojemność mF";
                    ret[2] = "mF";
                    break;
                case "VVoltage":
                    ret[0] = "DC Voltage";
                    ret[2] = "DC";
                    break;
                default:
                    ret[0] = label_value[0];
                    ret[2] = "";
                    break;
            }

            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            standardDisplayPanel.changeOpacity(tbPanelOpacity.Value);
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
    }
}
