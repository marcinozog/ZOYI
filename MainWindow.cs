using System.IO;
using System.IO.Ports;
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
        DisplayPanel formPanel;

        bool bMouseDown = false;
        Point mousePosDown = Point.Empty;
        Point currentFormLocation = Point.Empty;

        public MainWindow()
        {
            InitializeComponent();
            formPanel = new DisplayPanel();
            formPanel.StartPosition = FormStartPosition.CenterParent;
            refreshCOMlist();
            Directory.CreateDirectory("logs");
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
                        string[] label_value = parse_label_value(buff);

                        //buff += Environment.NewLine;
                        txtOutput.Invoke(new Action(() =>
                        {
                            txtOutput.AppendText(label_value[0] + " : " + label_value[1]);
                            txtOutput.AppendText(Environment.NewLine);
                        }));

                        formPanel.Invoke(new Action(() =>
                        {
                            formPanel.updateLabelValue(label_value[0], label_value[1]);
                        }));

                        buff = "";
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
                formPanel.Close();
            }
        }

        private void chbShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPanel.Checked)
            {
                formPanel.Show();
            }
            else
            {
                formPanel.Hide();
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

        string[] parse_label_value(string buff)
        {
            string[] label_value = buff.Split(':');

            switch (label_value[0])
            {
                case "MOMResistance":
                    label_value[0] = "MΩ";
                    label_value[1] += " MΩ";
                    break;
                case "OMResistance":
                    label_value[0] = "Ω";
                    label_value[1] += " Ω";
                    break;
                case "KOMResistance":
                    label_value[0] = "KΩ";
                    label_value[1] += " KΩ";
                    break;
                case "OMbeep":
                    label_value[0] = "Buzzer";
                    break;
                case "VDiode":
                    label_value[0] = "Tryb diody";
                    label_value[1] += " mV";
                    break;
                case "nFCap":
                    label_value[0] = "Kondek nF";
                    label_value[1] += " nF";
                    break;
                case "uFCap":
                    label_value[0] = "Kondek uF";
                    label_value[1] += " uF";
                    break;
                case "VVoltage":
                    label_value[0] = "DC Voltage";
                    label_value[1] += " DC";
                    break;
            }

            return label_value;
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
                formPanel.setBackgroundColor(cd.Color);
        }

        private void btnColorLabel_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;

            if (cd.ShowDialog() == DialogResult.OK)
                formPanel.setLabelFontColor(cd.Color);
        }

        private void btnColorValue_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = false;

            if (cd.ShowDialog() == DialogResult.OK)
                formPanel.setValueFontColor(cd.Color);
        }
    }
}
