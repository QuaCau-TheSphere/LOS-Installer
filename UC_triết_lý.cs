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
    public partial class UC_triết_lý : UserControl
    {
        public UC_triết_lý()
        {
            InitializeComponent();
            string tempFile2 = System.IO.Path.GetTempFileName().Replace(".tmp", ".rtf");
            File.WriteAllText(tempFile2, Properties.Resources.Nội_dung_UC_triết_lý);
            richTextBox1.LoadFile(tempFile2);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = e.LinkText, UseShellExecute = true });
        }
    }
}
