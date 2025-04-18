﻿using System;
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
    public partial class DisplayPanel : Form
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

        Color color_label;
        Color color_value;
        Color color_bg;

        public DisplayPanel()
        {
            InitializeComponent();
            this.Location = new Point(Properties.Settings.Default.panel_form_pos_x, Properties.Settings.Default.panel_form_pos_y);

            color_label = ColorTranslator.FromHtml(Properties.Settings.Default.panel_label_color);
            color_value = ColorTranslator.FromHtml(Properties.Settings.Default.panel_value_color);
            color_bg = ColorTranslator.FromHtml(Properties.Settings.Default.panel_bg_color);

            lblLabel.ForeColor = color_label;
            lblValue.ForeColor = color_value;
            this.BackColor = color_bg;
        }

        // update label, value, suffix
        public void updatePanel(string[] lvs)
        {
            lblLabel.Text = lvs[0];
            lblValue.Text = lvs[1] + " " + lvs[2];
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
            Properties.Settings.Default.panel_bg_color = ColorTranslator.ToHtml(color);
            Properties.Settings.Default.Save();
        }

        public void setLabelFontColor(Color color)
        {
            lblLabel.ForeColor = color;
            Properties.Settings.Default.panel_label_color = ColorTranslator.ToHtml(color);
            Properties.Settings.Default.Save();
        }

        public void setValueFontColor(Color color)
        {
            lblValue.ForeColor = color;
            Properties.Settings.Default.panel_value_color = ColorTranslator.ToHtml(color); ;
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
            Properties.Settings.Default.panel_form_pos_x = this.Location.X;
            Properties.Settings.Default.panel_form_pos_y = this.Location.Y;
            Properties.Settings.Default.Save();
        }
    }
}
