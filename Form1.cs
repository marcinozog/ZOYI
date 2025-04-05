using System.IO.Ports;
using System.Threading;

namespace ZOYI
{
    public partial class Form1 : Form
    {
        SerialPort port;
        String port_name;
        bool connected = false;
        Thread readThread;
        Form formPanel;

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
                            buff += Environment.NewLine;
                            txtOutput.Invoke(new Action(() =>
                            {
                                txtOutput.AppendText(buff.ToString());
                            }));
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbShowPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPanel.Checked)
            {
                chbShowPanel.Text = "Ukryj panel";
                formPanel.Show();
            }
            else
            {
                chbShowPanel.Text = "Poka¿ panel";
                formPanel.Hide();
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

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
