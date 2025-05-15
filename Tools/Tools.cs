using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOYI
{
    public class Tools
    {
        string toolsPath;
        Panel panelTools;
        int columnWidth = 0;

        /*
         * 
         */
        public Tools(string path, Panel panel)
        {
            toolsPath = path;
            panelTools = panel;

            columnWidth = panelTools.Width / 3;
        }

        public void refreshTools()
        {
            if (!File.Exists(toolsPath))
                File.Create(toolsPath).Close();

            panelTools.Controls.Clear();

            int yStartPos = 10;
            int yPos = yStartPos;
            int xPos = 10;

            int linkHeight = 31;

            foreach (string line in File.ReadLines(toolsPath))
            {
                // SECTION
                if (line.Contains("----"))
                {
                    Label label = new Label()
                    {
                        Left = xPos,
                        Top = yPos,
                        Width = columnWidth,
                        Height = linkHeight,
                        Text = line,
                        ForeColor = Color.Red,
                        AutoSize = false
                    };

                    panelTools.Controls.Add(label);

                    Size labelSize = TextRenderer.MeasureText(
                        label.Text,
                        label.Font,
                        new Size(columnWidth, int.MaxValue),
                        TextFormatFlags.WordBreak
                    );

                    // Label height - max two lines
                    if (labelSize.Height > linkHeight)
                    {
                        label.Height = 2 * linkHeight;
                        yPos += label.Height;
                    }
                    else
                        yPos += linkHeight;

                    // next column
                    if (yPos + 2 * linkHeight > panelTools.Height)
                    {
                        yPos = yStartPos;
                    }
                }
                // FILES
                else
                {
                    string[] link = line.Split("|");

                    LinkLabel ll = new LinkLabel()
                    {
                        Left = xPos,
                        Top = yPos,
                        Width = columnWidth,
                        Height = linkHeight,
                        Text = link[0],
                        LinkColor = Color.DeepSkyBlue,
                        AutoSize = false
                    };
                    ll.Links.Add(0, columnWidth, link[1]);
                    ll.LinkClicked += new LinkLabelLinkClickedEventHandler(openTool);

                    panelTools.Controls.Add(ll);

                    Size labelSize = TextRenderer.MeasureText(
                        ll.Text,
                        ll.Font,
                        new Size(columnWidth, int.MaxValue),
                        TextFormatFlags.WordBreak
                    );

                    // Link label height - max two lines
                    if (labelSize.Height > linkHeight)
                    {
                        ll.Height = 2 * linkHeight;
                        yPos += ll.Height;
                    }
                    else
                        yPos += linkHeight;

                    // next column
                    if (yPos + 2 * linkHeight > panelTools.Height)
                    {
                        yPos = yStartPos;
                        xPos += columnWidth;
                    }
                }
            }
        }

        /*
         * openUrl(object? sender, LinkLabelLinkClickedEventArgs e)
         */
        private void openTool(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            string? uri = e.Link!.LinkData as string;
            string toolsDir = Environment.CurrentDirectory + "\\Tools\\Files\\";

            if (!uri!.Contains("www") && File.Exists(toolsDir + uri))
                uri = toolsDir + uri;

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = uri,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }
    }
}
