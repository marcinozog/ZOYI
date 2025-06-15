using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZOYI
{
    public partial class StandardDisplayPanel : Form
    {
        // Window move
        bool bDispalyMouseDown = false;
        Point pDisplayMousePosDown = Point.Empty;
        Point pDisplayCurrentFormLocation = Point.Empty;

        // Window resize
        bool bResizeMouseDown = false;
        Point pResizeMousePosDown = Point.Empty;
        Size szCurrentFormSize = Size.Empty;
        Size szCurrentTableSize = Size.Empty;

        Font font_label;
        Font font_value;
        Font font_footer;
        Color color_label;
        Color color_value;
        Color color_footer;
        Color color_bg;

        CheckBox chbShowHide;

        public StandardDisplayPanel(CheckBox chb)
        {
            InitializeComponent();

            int xPos = Properties.Settings.Default.panel_std_form_pos_x;
            int yPos = Properties.Settings.Default.panel_std_form_pos_y;

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // prevent display panel outside screen
            if (xPos > screenWidth || xPos < 0)
                xPos = screenWidth / 3;

            if (yPos > screenHeight || yPos < 0)
                yPos = screenHeight / 3;

            this.Location = new Point(xPos, yPos);

            //this.Location = new Point(Properties.Settings.Default.panel_std_form_pos_x, Properties.Settings.Default.panel_std_form_pos_y);

            font_label = Properties.Settings.Default.panel_std_label_font;
            font_value = Properties.Settings.Default.panel_std_value_font;
            font_footer = Properties.Settings.Default.panel_std_footer_font;
            color_label = ColorTranslator.FromHtml(Properties.Settings.Default.panel_std_label_color);
            color_value = ColorTranslator.FromHtml(Properties.Settings.Default.panel_std_value_color);
            color_footer = ColorTranslator.FromHtml(Properties.Settings.Default.panel_std_footer_color);
            color_bg = ColorTranslator.FromHtml(Properties.Settings.Default.panel_std_bg_color);

            lblLabel.Font = font_label;
            lblValue.Font = font_value;
            lblLabel.ForeColor = color_label;
            lblValue.ForeColor = color_value;
            lblFreq.Font = font_footer;
            lblMode.Font = font_footer;
            lblFreq.ForeColor = color_footer;
            lblMode.ForeColor = color_footer;
            this.BackColor = color_bg;

            chbShowHide = chb;
        }

        // update label, value, suffix
        public void updatePanel(FrameDecoder frame_decoder)
        {
            lblLabel.Text = frame_decoder.Label;
            lblValue.Text = frame_decoder.Value + " " + frame_decoder.Unit;
            lblFreq.Text = frame_decoder.Freq + " " + frame_decoder.Freq_unit;
            lblMode.Text = frame_decoder.Mode1;
        }

        /*
         * 
         * Window move section
         * 
         */
        private void displayPanel_MouseDown(object sender, MouseEventArgs e)
        {
            bDispalyMouseDown = true;
            pDisplayMousePosDown = Control.MousePosition;
            pDisplayCurrentFormLocation = Location;
        }

        private void displayPanel_MouseUp(object sender, MouseEventArgs e)
        {
            bDispalyMouseDown = false;
            pDisplayMousePosDown = Point.Empty;
            pDisplayCurrentFormLocation = Point.Empty;
        }

        private void displayPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDispalyMouseDown)
            {
                var currentPos = Control.MousePosition;
                var distX = currentPos.X - pDisplayMousePosDown.X;
                var distY = currentPos.Y - pDisplayMousePosDown.Y;
                Location = new Point(pDisplayCurrentFormLocation.X + distX, pDisplayCurrentFormLocation.Y + distY);
            }
        }

        /*
         * 
         * Colors section
         * 
         */
        public void setBackgroundColor(Color color)
        {
            this.BackColor = color;
            Properties.Settings.Default.panel_std_bg_color = ColorTranslator.ToHtml(color);
            Properties.Settings.Default.Save();
        }

        public void setLabelFontColor(Color color)
        {
            lblLabel.ForeColor = color;
            Properties.Settings.Default.panel_std_label_color = ColorTranslator.ToHtml(color);
            Properties.Settings.Default.Save();
        }

        public void setValueFontColor(Color color)
        {
            lblValue.ForeColor = color;
            Properties.Settings.Default.panel_std_value_color = ColorTranslator.ToHtml(color); ;
            Properties.Settings.Default.Save();
        }

        public void changeOpacity(int val)
        {
            double opacity = val / 100.0;
            this.Opacity = opacity;
        }

        /*
         * 
         * Resize panel section
         * 
         */
        private void panelResize_MouseDown(object sender, MouseEventArgs e)
        {
            bResizeMouseDown = true;
            pResizeMousePosDown = Control.MousePosition;
            szCurrentFormSize = this.Size;
            szCurrentTableSize = tableLayoutPanel.Size;
        }

        private void panelResize_MouseUp(object sender, MouseEventArgs e)
        {
            bResizeMouseDown = false;
            pResizeMousePosDown = Point.Empty;
            szCurrentFormSize = Size.Empty;
            szCurrentTableSize = Size.Empty;
        }

        private void panelResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (bResizeMouseDown)
            {
                var currentPos = Control.MousePosition;
                var distX = currentPos.X - pResizeMousePosDown.X;
                var distY = currentPos.Y - pResizeMousePosDown.Y;
                this.Size = new Size(szCurrentFormSize.Width + distX, szCurrentFormSize.Height + distY);
                tableLayoutPanel.Size = new Size(szCurrentTableSize.Width + distX, szCurrentTableSize.Height + distY);

                try
                {
                    Font labelOldFont = lblLabel.Font;
                    //float fontOldSize = labelOldFont.Size;
                    float fontNewSize = lblLabel.Height / 3;
                    Font labelNewFont = new Font(labelOldFont.FontFamily, fontNewSize, labelOldFont.Style);
                    lblLabel.Font = labelNewFont;
                    lblValue.Font = labelNewFont;
                }
                catch { }
            }
        }

        private void DisplayPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.panel_std_form_pos_x = this.Location.X;
            Properties.Settings.Default.panel_std_form_pos_y = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemLabel.Checked)
                lblLabel.Visible = true;
            else
                lblLabel.Visible = false;

            if (toolStripMenuItemValue.Checked)
                lblValue.Visible = true;
            else
                lblValue.Visible = false;

            if (toolStripMenuItemFooter.Checked)
            {
                lblFreq.Visible = true;
                lblMode.Visible = true;
            }
            else
            {
                lblFreq.Visible = false;
                lblMode.Visible = false;
            }
        }

        private void zamknijPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            chbShowHide.Checked = false;
        }

        private void toolStripMenuItemFontLabel_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = lblLabel.Font;
            fontDialog.Color = lblLabel.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblLabel.Font = fontDialog.Font;
                lblLabel.ForeColor = fontDialog.Color;

                Properties.Settings.Default.panel_std_label_font = lblLabel.Font;
                Properties.Settings.Default.panel_std_label_color = ColorTranslator.ToHtml(lblLabel.ForeColor);
                Properties.Settings.Default.Save();
            }
        }

        private void toolStripMenuItemFontValue_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = lblValue.Font;
            fontDialog.Color = lblValue.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblValue.Font = fontDialog.Font;
                lblValue.ForeColor = fontDialog.Color;

                Properties.Settings.Default.panel_std_value_font = lblValue.Font;
                Properties.Settings.Default.panel_std_value_color = ColorTranslator.ToHtml(lblValue.ForeColor);
                Properties.Settings.Default.Save();
            }
        }

        private void toolStripMenuItemFontFooter_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = lblFreq.Font;
            fontDialog.Color = lblFreq.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblFreq.Font = fontDialog.Font;
                lblFreq.ForeColor = fontDialog.Color;
                lblMode.Font = fontDialog.Font;
                lblMode.ForeColor = fontDialog.Color;

                Properties.Settings.Default.panel_std_footer_font = lblFreq.Font;
                Properties.Settings.Default.panel_std_footer_color = ColorTranslator.ToHtml(lblFreq.ForeColor);
                Properties.Settings.Default.Save();
            }
        }
    }
}
