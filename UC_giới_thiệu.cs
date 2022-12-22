using System.Diagnostics;

namespace LOS_Installer
{
    public partial class UC_giới_thiệu : UserControl
    {
        public UC_giới_thiệu()
        {
            InitializeComponent();
            richTextBoxGiớiThiệu.LoadFile(".\\Resources\\Giới thiệu.rtf");
            richTextBoxGiớiThiệu.SelectAll();
            richTextBoxGiớiThiệu.SelectionFont = new Font("Segoe UI", 12F);
            richTextBoxGiớiThiệu.DeselectAll();
        }

        private void richTextBoxGiớiThiệu_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = e.LinkText, UseShellExecute = true });
        }
    }
}
