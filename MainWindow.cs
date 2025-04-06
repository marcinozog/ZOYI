using System.IO;
using System.IO.Ports;
using System.Media;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace ZOYI
{
    public partial class MainWindow : Form
    {
        SerialPort port;
        String port_name;
        bool connected = false;
        Thread readThread;
        DisplayPanel displayPanel;

        bool bMouseDown = false;
        Point mousePosDown = Point.Empty;
        Point currentFormLocation = Point.Empty;

        public MainWindow()
        {
            InitializeComponent();
            displayPanel = new DisplayPanel();
            displayPanel.StartPosition = FormStartPosition.CenterParent;
            refreshCOMlist();
            Directory.CreateDirectory("logs");
            cbAlarmLabel.SelectedItem = "Voltage";
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

                    readThread = new Thread(new ThreadStart(ReadCOM));
                    readThread.Start();
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

                readThread.Interrupt();
            }

        }

        void ReadCOM()
        {
            String buff = "";
            while (connected)
            {
                //if (txtOutput.InvokeRequired)
                //{
                try
                {
                    char c = (char)port.ReadChar();
                    buff += c;

                    if (c == ' ')
                    {
                        string[] lvs = parse_label_value_suffix(buff);
                        buff = "";

                        //buff += Environment.NewLine;
                        txtOutput.Invoke(new Action(() =>
                        {
                            txtOutput.AppendText(lvs[0] + " : " + lvs[1] + " " + lvs[2]);
                            txtOutput.AppendText(Environment.NewLine);
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
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                }
                //}

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (connected)
            {
                connected = false;
                readThread.Interrupt();
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
            txtOutput.Text = "";
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            File.WriteAllText("logs\\" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log", txtOutput.Text);
        }

        string[] parse_label_value_suffix(string buff)
        {
            string[] label_value = buff.Split(':');
            // label, value, suffix
            string[] ret = new string[3];
            ret[1] = label_value[1];

            switch (label_value[0])
            {
                case "Electricity":
                    //label_value[0] = "Ampery";
                    //label_value[1] += " A";
                    ret[0] = "Ampery";
                    ret[2] += "A";
                    break;
                case "AElectricity":
                    //label_value[0] = "Ampery";
                    //label_value[1] += " A";
                    ret[0] = "Ampery";
                    ret[2] = "A";
                    break;
                case "mAElectricity":
                    //label_value[0] = "Ampery";
                    //label_value[1] += " mA";
                    ret[0] = "Ampery";
                    ret[2] = "mA";
                    break;
                case "MOMResistance":
                    //label_value[0] = "Rezystancja";
                    //label_value[1] += " MΩ";
                    ret[0] = "Rezystancja";
                    ret[2] = "MΩ";
                    break;
                case "OMResistance":
                    //label_value[0] = "Rezystancja";
                    //label_value[1] += " Ω";
                    ret[0] = "Rezystancja";
                    ret[2] = "Ω";
                    break;
                case "KOMResistance":
                    //label_value[0] = "Rezystancja";
                    //label_value[1] += " KΩ";
                    ret[0] = "Rezystancja";
                    ret[2] = "KΩ";
                    break;
                case "OMbeep":
                    //label_value[0] = "Buzzer";
                    ret[0] = "Buzzer";
                    ret[2] = "";
                    break;
                case "VDiode":
                    //label_value[0] = "Tryb diody";
                    //label_value[1] += " mV";
                    ret[0] = "Tryb diody";
                    ret[2] = "mV";
                    break;
                case "nFCap":
                    //label_value[0] = "Pojemność nF";
                    //label_value[1] += " nF";
                    ret[0] = "Pojemność nF";
                    ret[2] = "nF";
                    break;
                case "uFCap":
                    //label_value[0] = "Pojemność uF";
                    //label_value[1] += " uF";
                    ret[0] = "Pojemność uF";
                    ret[2] = "uF";
                    break;
                case "mFCap":
                    //label_value[0] = "Pojemność mF";
                    //label_value[1] += " mF";
                    ret[0] = "Pojemność mF";
                    ret[2] = "mF";
                    break;
                case "VVoltage":
                    //label_value[0] = "DC Voltage";
                    //label_value[1] += " DC";
                    ret[0] = "DC Voltage";
                    ret[2] = "DC";
                    break;
            }

            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

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

        private void chbAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAlarm.Checked)
            {
                displayPanel.enable_alarm(true);
                displayPanel.set_alarm_label(cbAlarmLabel.Text);
                displayPanel.set_alarm_value(tbAlarmValue.Text);
            }
            else
            {
                displayPanel.enable_alarm(false);
            }

        }
    }
}
