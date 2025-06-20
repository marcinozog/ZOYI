﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ZOYIv2;
//using static ZOYI.ArcProgressBar;

namespace ZOYI
{
    public partial class AdancedDisplayPanel : Form
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
        //Font font_footer;
        Color color_label;
        Color color_value;
        Color color_footer;
        Color color_bg;

        int Ticks = 0;
        int ThicksCount = 0;

        CheckBox chbShowHide;

        public AdancedDisplayPanel(CheckBox chb)
        {
            InitializeComponent();

            int xPos = Properties.Settings.Default.panel_adv_form_pos_x;
            int yPos = Properties.Settings.Default.panel_adv_form_pos_y;

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // prevent display panel outside screen
            if (xPos > screenWidth || xPos < 0)
                xPos = screenWidth / 3;

            if (yPos > screenHeight || yPos < 0)
                yPos = screenHeight / 3;

            this.Location = new Point(xPos, yPos);

            //this.Location = new Point(Properties.Settings.Default.panel_adv_form_pos_x, Properties.Settings.Default.panel_adv_form_pos_y);

            font_label = Properties.Settings.Default.panel_adv_label_font;
            font_value = Properties.Settings.Default.panel_adv_value_font;
            //font_footer = Properties.Settings.Default.panel_adv_footer_font;
            color_label = ColorTranslator.FromHtml(Properties.Settings.Default.panel_adv_label_color);
            color_value = ColorTranslator.FromHtml(Properties.Settings.Default.panel_adv_value_color);
            color_bg = ColorTranslator.FromHtml(Properties.Settings.Default.panel_adv_bg_color);

            lblLabel.Font = font_label;
            lblValue.Font = font_value;
            lblLabel.ForeColor = color_label;
            lblValue.ForeColor = color_value;
            this.BackColor = color_bg;

            Ticks = Properties.Settings.Default.panel_adv_ticks;
            arcProgressBar1.MaximumTick = Ticks;

            ThicksCount = Properties.Settings.Default.panel_adv_thicks_count;
            arcProgressBar1.MajorThicksCount = ThicksCount;

            chbShowHide = chb;

            //lblValue.Parent = arcProgressBar1;
        }

        // update label, value, suffix
        public void updatePanel(FrameDecoder frame_decoder)
        {
            lblLabel.Text = frame_decoder.Label;
            lblValue.Text = frame_decoder.Value + " " + frame_decoder.Unit;
            lblFreq.Text = frame_decoder.Freq + " " + frame_decoder.Freq_unit;
            lblMode.Text = frame_decoder.Mode1;

            float val = 0;

            //float val = float.Parse(frame_decode.Value.Replace(',', '.'), CultureInfo.InvariantCulture.NumberFormat);
            float.TryParse(frame_decoder.Value, CultureInfo.InvariantCulture.NumberFormat, out val);
            arcProgressBar1.Value = val;
        }

        public void setArcProgressBarTicks(int val)
        {
            Ticks = val;
            arcProgressBar1.MaximumTick = Ticks;
            //arcProgressBar1.MajorThicksCount = Ticks;
        }

        public void setArcProgressBarThicksCount(int val)
        {
            ThicksCount = val;
            arcProgressBar1.MajorThicksCount = ThicksCount;
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
            Properties.Settings.Default.panel_adv_bg_color = ColorTranslator.ToHtml(color);
            Properties.Settings.Default.Save();
        }

        public void setLabelFontColor(Color color)
        {
            lblLabel.ForeColor = color;
            Properties.Settings.Default.panel_adv_label_color = ColorTranslator.ToHtml(color);
            Properties.Settings.Default.Save();
        }

        public void setValueFontColor(Color color)
        {
            lblValue.ForeColor = color;
            Properties.Settings.Default.panel_adv_value_color = ColorTranslator.ToHtml(color); ;
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
            //szCurrentTableSize = tableLayoutPanel.Size;
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
                //tableLayoutPanel.Size = new Size(szCurrentTableSize.Width + distX, szCurrentTableSize.Height + distY);

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

        private void AdancedDisplayPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.panel_adv_form_pos_x = this.Location.X;
            Properties.Settings.Default.panel_adv_form_pos_y = this.Location.Y;
            Properties.Settings.Default.panel_adv_ticks = Ticks;
            Properties.Settings.Default.panel_adv_thicks_count = ThicksCount;
            Properties.Settings.Default.Save();
        }

        private void toolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItemArcBar.Checked)
                arcProgressBar1.Visible = true;
            else
                arcProgressBar1.Visible = false;

            if (toolStripMenuItemLabel.Checked)
                lblLabel.Visible = true;
            else
                lblLabel.Visible = false;

            if (toolStripMenuItemValue.Checked)
                lblValue.Visible = true;
            else
                lblValue.Visible = false;
        }

        private void zamknijPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            chbShowHide.Checked = false;
        }

        private void toolStripMenuItemLabelFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = lblLabel.Font;
            fontDialog.Color = lblLabel.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblLabel.Font = fontDialog.Font;
                lblLabel.ForeColor = fontDialog.Color;

                Properties.Settings.Default.panel_adv_label_font = lblLabel.Font;
                Properties.Settings.Default.panel_adv_label_color = ColorTranslator.ToHtml(lblLabel.ForeColor);
                Properties.Settings.Default.Save();
            }
        }

        private void toolStripMenuItemValueFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowColor = true;
            fontDialog.Font = lblValue.Font;
            fontDialog.Color = lblValue.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                lblValue.Font = fontDialog.Font;
                lblValue.ForeColor = fontDialog.Color;

                Properties.Settings.Default.panel_adv_value_font = lblValue.Font;
                Properties.Settings.Default.panel_adv_value_color = ColorTranslator.ToHtml(lblValue.ForeColor);
                Properties.Settings.Default.Save();
            }
        }
    }
}

