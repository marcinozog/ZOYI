using System.IO.Ports;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace ZOYI
{
    public partial class Form1 : Form
    {
        SerialPort port;
        String port_name;
        bool connected = false;
        Thread readThread;
        FormPanel formPanel;

        public Form1()
        {
            InitializeComponent();
            formPanel = new FormPanel();
            refreshCOMlist();
        }

        private void btnListCOM_Click(object sender, EventArgs e)
        {
            refreshCOMlist();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                port_name = listBox1.SelectedItem.ToString();
                port = new SerialPort(port_name, 115200, Parity.None, 8, StopBits.One);
                port.Open();
                connected = true;
                btnConnect.Text = "Roz³¹cz";

                readThread = new Thread(new ThreadStart(ReadCOM));
                readThread.Start();
            }
            else
            {
                port.Close();
                connected = false;
                btnConnect.Text = "Po³¹cz";

                readThread.Interrupt();
            }

        }

        void ReadCOM()
        {
            String buff = "";
            while (connected)
            {
                if (txtOutput.InvokeRequired)
                {
                    try
                    {
                        char c = (char)port.ReadChar();
                        buff += c;

                        if (c == ' ') {
                            string[] label_value = buff.Split(':');

                            buff += Environment.NewLine;
                            txtOutput.Invoke(new Action(() =>
                            {
                                txtOutput.AppendText(buff.ToString());
                            }));

                            formPanel.Invoke(new Action(() =>
                            {
                                formPanel.updateLabelValue(label_value[0], label_value[1]);
                            }));
                            //formPanel.Refresh();
                            buff = "";
                        }
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show(e.ToString());
                    }
                }

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
            listBox1.Items.Clear();

            foreach (string port in ports)
            {
                listBox1.Items.Add(port);
            }
        }
    }
}
