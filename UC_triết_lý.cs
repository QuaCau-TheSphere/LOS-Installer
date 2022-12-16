using System.Diagnostics;

namespace LOS_Installer
{
    public partial class UC_triết_lý : UserControl
    {
        public UC_triết_lý()
        {
            InitializeComponent();
            richTextBoxTriếtLý.LoadFile(".\\Resources\\Triết lý.rtf");
            //richTextBoxTriếtLý.LoadFile(".\\Resources\\test.rtf");
            //richTextBoxTriếtLý.LoadFile(".\\test.rtf", RichTextBoxStreamType.RichText);
            richTextBoxTriếtLý.SelectAll();
            richTextBoxTriếtLý.SelectionFont = new Font("Segoe UI", 12F);
            richTextBoxTriếtLý.DeselectAll();

            //var webBrowser = new WebBrowser();
            //webBrowser.CreateControl(); // only if needed
            //webBrowser.DocumentText = Properties.Resources.html;
            //while (webBrowser.DocumentText != Properties.Resources.html)
            //    Application.DoEvents();
            //webBrowser.Document.ExecCommand("SelectAll", false, null);
            //webBrowser.Document.ExecCommand("Copy", false, null);
            //Properties.Resources.html.Paste();

        }

        private void richTextBoxTriếtLý_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = e.LinkText, UseShellExecute = true });
        }
    }
}
