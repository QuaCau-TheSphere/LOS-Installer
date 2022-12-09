using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOS_Installer
{
    public partial class UC_gặp_nhau : UserControl
    {
        public UC_gặp_nhau()
        {
            InitializeComponent();
        }
        private void button_facebook_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://www.facebook.com/groups/landofspheres", UseShellExecute = true });
        }

        private void button_discord_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://discord.gg/jWTk4EHFK2" , UseShellExecute = true });
        }

        private void richTextBox_gặp_nhau_Enter(object sender, EventArgs e)
        {
            richTextBox_gặp_nhau.Enabled = false;
            richTextBox_gặp_nhau.Enabled = true;
        }
    }
}
