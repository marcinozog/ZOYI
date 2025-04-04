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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListCOM_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            listBox1.Items.Clear();

            foreach (string port in ports)
            {
                listBox1.Items.Add(port);
            }
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
            while (connected)
            {
                if (txtOutput.InvokeRequired)
                {
                    try
                    {
                        char message = (char)port.ReadChar();
                        txtOutput.Invoke(new Action(() =>
                        {
                            txtOutput.AppendText(message.ToString());
                        }));
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
            connected = false;
            readThread.Interrupt();
        }
    }
}
