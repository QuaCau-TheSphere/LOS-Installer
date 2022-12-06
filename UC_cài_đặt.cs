using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LOS_Installer
{
    public partial class UC_cài_đặt : UserControl
    {
        string path; 
        public UC_cài_đặt()
        {
            InitializeComponent();
        }

        public void button_chọn_thư_mục_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "D:\\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox_thư_mục.Text = dialog.FileName;
            }
            path = textBox_thư_mục.Text;
        }
        public void button_bắt_đầu_Click(object sender, EventArgs e)
        {
            if (path == null ) {
                MessageBox.Show("Hãy chọn thư mục chứa dữ liệu");
            }
            if (path != null ) {
                MessageBox.Show("yo");
            }
        }
    }
}
