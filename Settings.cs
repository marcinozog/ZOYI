using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace ZOYI
{
    internal class Settings
    {
        int baudrate;
        string default_com = "";
        string lang = "";
        string color_label_panel = "";
        string color_value_panel = "";

        public void load_settings()
        {
            int baudrate = Properties.Settings.Default.baudrate;
            string default_com = Properties.Settings.Default.default_com;
            string lang = Properties.Settings.Default.lang;
            string color_label_panel = Properties.Settings.Default.color_label_panel;
            string color_value_panel = Properties.Settings.Default.color_value_panel;
        }

        public void save_settings()
        {
            Properties.Settings.Default.baudrate = baudrate;
            Properties.Settings.Default.default_com = default_com;
            Properties.Settings.Default.lang = lang;
            Properties.Settings.Default.color_label_panel = color_label_panel;
            Properties.Settings.Default.color_value_panel = color_value_panel;
            Properties.Settings.Default.Save();
        }
    }
}
