using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOYI
{
    public partial class MainWindow : Form
    {
        String? COMportName = "";
        PARSE_MODE COMparseMode = PARSE_MODE.STD;
        CancellationTokenSource ctsReadCOM;

        /*
         * 
         */
        private void rbComParse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCOMparseStd.Checked)
                COMparseMode = PARSE_MODE.STD;
            else if (rbCOMparseLua.Checked)
            {
                COMparseMode = PARSE_MODE.LUA;
                mLua.LuaReload(luaPath);
            }
            else
                COMparseMode = PARSE_MODE.RAW;
        }

        /*
         * 
         */
        private async void btnCOMluaEdit_Click(object sender, EventArgs e)
        {
            RichEditor re = new RichEditor(mLua);
            re.loadFile(luaPath, RichEditor.ENCODING.LUA);

            string result = await re.AsyncEdit();

            if (result == "save")
                mLua.LuaReload(luaPath);
        }

        /*
         * 
         */
        private void btnListCOM_Click(object sender, EventArgs e)
        {
            refreshCOMlist();
        }

        /*
         * 
         */
        private void btnComConnect_Click(object sender, EventArgs e)
        {
            if (!comx.isConnected())
            {
                try
                {
                    COMportName = lbListCOMs.SelectedItem!.ToString();
                    int baudrate = int.Parse(tbCOMBaudrate.Text);

                    comx.connect(COMportName!, baudrate);

                    btnComConnect.Text = "Rozłącz " + COMportName;
                    btnComConnect.BackColor = Color.LightCoral;
                    lbListCOMs.Enabled = false;
                    tbCOMBaudrate.Enabled = false;
                    lblComConnStatus.Text = "podłączony";
                    lblComConnStatus.ForeColor = Color.LightCoral;

                    ctsReadCOM = new CancellationTokenSource();
                    var task = Task.Run(() => readCom(ctsReadCOM.Token));
                    Console.WriteLine("Task readCom run...");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("btnComConnect_Click:" + ex);
                    Console.WriteLine(ex);
                }
            }
            else
            {
                ctsReadCOM.Cancel();
                ctsReadCOM.Dispose();

                comx.disconnect();

                btnComConnect.Text = "Połącz";
                btnComConnect.BackColor = Color.LightGreen;
                lblComConnStatus.Text = "rozłączony";
                lblComConnStatus.ForeColor = Color.LightGreen;

                lbListCOMs.Enabled = true;
                tbCOMBaudrate.Enabled = true;
            }
        }

        async Task readCom(CancellationToken token)
        {
            String buff = "";

            try
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        int readByte = await comx.readByteAsync();

                        if (readByte == -1)
                            continue;

                        char c = (char)readByte;

                        if (COMparseMode == PARSE_MODE.RAW)
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
                                //string[] lvs;
                                //if (COMparseMode == PARSE_MODE.LUA)
                                //    lvs = mLua.parseLabelValueSuffix_LUA(buff);
                                //else
                                //    lvs = parseLabelValueSuffix_STD(buff);

                                if (COMparseMode == PARSE_MODE.LUA)
                                    lvs.SetFromArray(mLua.parseLabelValueSuffix_LUA(buff));
                                else
                                    lvs.SetFromArray(parseLabelValueSuffix_STD(buff));

                                buff = "";

                                tbComOutput.Invoke(new Action(() =>
                                {
                                    tbComOutput.AppendText(lvs.Label + " : " + lvs.Value + " " + lvs.Suffix);
                                    tbComOutput.AppendText(Environment.NewLine);
                                }));

                                // wyjątek kiedy panel ukryty
                                // dodać bool panel visible
                                try
                                {
                                    standardDisplayPanel.Invoke(new Action(() =>
                                    {
                                        standardDisplayPanel.updatePanel(lvs);
                                    }));

                                    advancedDisplayPanel.Invoke(new Action(() =>
                                    {
                                        advancedDisplayPanel.updatePanel(lvs);
                                    }));
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("readCom Exception");
                                }

                                if (bAlarmEnable)
                                    alarmProcess(lvs.Label, lvs.Value);
                            }
                        }
                    }
                    catch (TimeoutException)
                    {
                        Console.WriteLine("TimeoutException");
                    }
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("OperationCanceledException");
            }

            Console.WriteLine("Task readCom finish");
        }

        /*
         * 
         */
        void refreshCOMlist()
        {
            lbListCOMs.DataSource = comx.listCOMports();
        }

        /*
         * 
         */
        private void btnComClearLog_Click(object sender, EventArgs e)
        {
            tbComOutput.Text = "";
        }

        /*
         * 
         */
        private void btnComSaveLog_Click(object sender, EventArgs e)
        {
            File.WriteAllText("logs\\COM_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log", tbComOutput.Text);
        }
    }
}
