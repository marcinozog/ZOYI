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
    public partial class DisplayPanel : Form
    {
        bool bMouseDown = false;
        Point mousePosDown = Point.Empty;
        Point currentFormLocation = Point.Empty;

        Color color_label;
        Color color_value;
        Color color_bg;

        public DisplayPanel()
        {
            InitializeComponent();

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

        private void displayPanel_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            mousePosDown = Control.MousePosition;
            currentFormLocation = Location;
        }

        private void displayPanel_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
            mousePosDown = Point.Empty;
            currentFormLocation = Point.Empty;
        }

        private void displayPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (bMouseDown)
            {
                var currentPos = Control.MousePosition;
                var distX = currentPos.X - mousePosDown.X;
                var distY = currentPos.Y - mousePosDown.Y;
                Location = new Point(currentFormLocation.X + distX, currentFormLocation.Y + distY);
            }
        }

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
    }
}
