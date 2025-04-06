using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        bool alarmo_on = false;
        string alarm_label = "";
        int alarm_value = 0;

        public DisplayPanel()
        {
            InitializeComponent();
        }

        public void updateLabelValue(string label, string value)
        {
            lblLabel.Text = label;
            lblValue.Text = value;

            if (alarmo_on)
            {

            }
        }

        private void FormPanel_MouseDown(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            mousePosDown = Control.MousePosition;
            currentFormLocation = Location;
        }

        private void FormPanel_MouseUp(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
            mousePosDown = Point.Empty;
            currentFormLocation = Point.Empty;
        }

        private void FormPanel_MouseMove(object sender, MouseEventArgs e)
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
        }

        public void setLabelFontColor(Color color)
        {
            lblLabel.ForeColor = color;
        }

        public void setValueFontColor(Color color)
        {
            lblValue.ForeColor = color;
        }
    }
}
