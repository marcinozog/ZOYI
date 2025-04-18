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

            panelLinks.Controls.Clear();

            int yStartPos = 10;
            int yPos = yStartPos;
            int xPos = 10;

            int linkHeight = 31;
            int columnWidth = panelLinks.Width/2;

            bool bOddColor = true;

            foreach (string line in File.ReadLines(links_path))
            {
                string[] link = line.Split("|");

                LinkLabel ll = new LinkLabel()
                {
                    Left = xPos,
                    Top = yPos,
                    Width = columnWidth,
                    Height = linkHeight,
                    Text = link[0],
                    LinkColor = bOddColor ? Color.DeepSkyBlue : Color.LightGreen,
                    AutoSize = false
                };
                ll.Links.Add(0, 40, link[1]);
                ll.LinkClicked += new LinkLabelLinkClickedEventHandler(openUrl);

                // change label color
                bOddColor = !bOddColor;

                panelLinks.Controls.Add(ll);

                Size labelSize = TextRenderer.MeasureText(
                    ll.Text,
                    ll.Font,
                    new Size(columnWidth, int.MaxValue),
                    TextFormatFlags.WordBreak
                );

                // for max two lines of link label
                if (labelSize.Height > linkHeight)
                {
                    ll.Height = 2 * linkHeight;
                    yPos += ll.Height;
                }
                else
                    yPos += linkHeight;

                // next column
                if ((yPos + (2 * linkHeight)) > panelLinks.Height)
                {
                    yPos = yStartPos;
                    xPos += columnWidth;
                }
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
