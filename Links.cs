using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOYI
{
    public partial class MainWindow : Form
    {
        string links_path = "Links.txt";

        private void btnLinksEdit_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "Links.txt");
        }

        private void btnLinksRefresh_Click(object sender, EventArgs e)
        {
            refreshLinks();
        }

        private void refreshLinks()
        {
            if (!File.Exists(links_path))
                File.Create(links_path).Close();

            int xPos = 10;
            int yPos = 10;
            foreach (string line in File.ReadLines(links_path))
            {
                string[] link = line.Split(" ");

                LinkLabel ll = new LinkLabel() { Left = xPos, Top = yPos, Width = 100, Height = 31, Text = link[0], LinkColor = Color.DodgerBlue };
                ll.Links.Add(0, 20, link[1]);
                ll.LinkClicked += new LinkLabelLinkClickedEventHandler(openUrl);

                panelLinks.Controls.Add(ll);
                yPos += 30;
            }
        }

        private void openUrl(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (string)e.Link.LinkData;
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
