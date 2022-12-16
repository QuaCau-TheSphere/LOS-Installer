using System.Diagnostics;

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
            Process.Start(new ProcessStartInfo { FileName = "https://discord.gg/jWTk4EHFK2", UseShellExecute = true });
        }
    }
}
