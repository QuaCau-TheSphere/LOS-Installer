using System.Diagnostics;

namespace LOS_Installer
{
    public partial class UC_triết_lý : UserControl
    {
        public UC_triết_lý()
        {
            InitializeComponent();
            richTextBoxTriếtLý.LoadFile(".\\Resources\\Triết lý.rtf");
            richTextBoxTriếtLý.SelectAll();
            richTextBoxTriếtLý.SelectionFont = new Font("Segoe UI", 12F);
            richTextBoxTriếtLý.DeselectAll();
        }

        private void richTextBoxTriếtLý_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = e.LinkText, UseShellExecute = true });
        }
    }
}
