using System.Globalization;
using System.IO.Ports;
using System.Media;

namespace ZOYI
{
    public partial class MainWindow : Form
    {
        SerialPort port;
        String port_name;
        bool connected = false;
        Thread readComThread;
        DisplayPanel displayPanel;
        bool bCOMrawmode = false;

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
            displayPanel = new DisplayPanel();
            displayPanel.StartPosition = FormStartPosition.CenterParent;
            refreshCOMlist();
            Directory.CreateDirectory("logs");
            cbAlarmLabel.SelectedItem = "Voltage";

            refreshLinks();
        }

        private void btnListCOM_Click(object sender, EventArgs e)
        {
            refreshCOMlist();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                try
                {
                    port_name = lbCOMs.SelectedItem.ToString();
                    int baudrate = int.Parse(txtBaudRate.Text);
                    port = new SerialPort(port_name, baudrate, Parity.None, 8, StopBits.One);
                    port.Open();
                    connected = true;
                    btnConnect.Text = "Rozłącz " + port_name;
                    btnConnect.BackColor = Color.LightCoral;

                    lbCOMs.Enabled = false;
                    txtBaudRate.Enabled = false;

                    readComThread = new Thread(new ThreadStart(ReadCOMThread));
                    readComThread.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                port.Close();
                connected = false;
                btnConnect.Text = "Połącz";
                btnConnect.BackColor = Color.LightGreen;

                lbCOMs.Enabled = true;
                txtBaudRate.Enabled = true;

                readComThread.Interrupt();
            }

        }

        void ReadCOMThread()
        {
            String buff = "";
            while (connected)
            {
                //if (txtOutput.InvokeRequired)
                //{
                try
                {
                    char c = (char)port.ReadChar();
                    if (bCOMrawmode)
                    {
                        tbComOutput.Invoke(new Action(() =>
                        {
                            tbComOutput.AppendText(c.ToString());
                        }));
                    }
                    else
                    {
                        buff += c;

                        if (c == ' ')
                        {
                            // label, value, suffix
                            string[] lvs = parse_label_value_suffix(buff);
                            buff = "";

                            //buff += Environment.NewLine;
                            tbComOutput.Invoke(new Action(() =>
                            {
                                tbComOutput.AppendText(lvs[0] + " : " + lvs[1] + " " + lvs[2]);
                                tbComOutput.AppendText(Environment.NewLine);
                            }));

                            // wyjątek kiedy panel ukryty
                            try
                            {
                                displayPanel.Invoke(new Action(() =>
                                {
                                    displayPanel.updatePanel(lvs);
                                }));
                            }
                            catch (Exception ex) { }

                            if (bAlarmEnable)
                                alarmProcess(lvs[0], lvs[1]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
                //}
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connected)
            {
                port.Close();
                connected = false;
                readComThread.Interrupt();
                displayPanel.Close();
            }
        }

        private void chbShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPanel.Checked)
            {
                displayPanel.Show();
            }
            else
            {
                displayPanel.Hide();
            }
        }

        void refreshCOMlist()
        {
            string[] ports = SerialPort.GetPortNames();
            lbCOMs.Items.Clear();

            foreach (string port in ports)
            {
                lbCOMs.Items.Add(port);
            }

            if (ports.Length > 0)
                lbCOMs.SelectedIndex = 0;
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
        string[] parse_label_value_suffix(string buff)
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
                displayPanel.setBackgroundColor(cd.Color);
        }

        private void btnColorLabel_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;

            if (cd.ShowDialog() == DialogResult.OK)
                displayPanel.setLabelFontColor(cd.Color);
        }

        private void btnColorValue_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;

            if (cd.ShowDialog() == DialogResult.OK)
                displayPanel.setValueFontColor(cd.Color);
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
                    // break if fail - don't use TryParse
                    //float val = float.Parse(value);
                    float val = float.Parse(value, CultureInfo.InvariantCulture.NumberFormat);
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
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        void playAlarmBeepThread()
        {
            SoundPlayer snd = new SoundPlayer("beep.wav");
            snd.PlaySync();
            bBeepPlaying = false;
        }

        private void tbPanelOpacity_Scroll(object sender, EventArgs e)
        {
            displayPanel.changeOpacity(tbPanelOpacity.Value);
        }

        private void cbCOMrawmode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCOMrawmode.Checked)
                bCOMrawmode = true;
            else
                bCOMrawmode = false;
        }
    }
}
