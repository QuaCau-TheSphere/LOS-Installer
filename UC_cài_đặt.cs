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
            textBoxLog.Visible = false;
        }

        public void button_chọn_thư_mục_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = "D:\\",
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox_thư_mục.Text = dialog.FileName;
            }
            path = textBox_thư_mục.Text;
        }
        public async void button_bắt_đầu_Click(object sender, EventArgs e)
        {
            if (path == null ) {
                MessageBox.Show("Hãy chọn thư mục chứa dữ liệu");
                return;
            }
            textBoxLog.Visible = true;
            button_bắt_đầu.Enabled = false;
            await Task.Run(() => {
                var proc = new Process();
                proc.StartInfo.FileName = @"G:\My Drive\Quả Cầu\6 Tổ chức\D Kỹ thuật\LOS Installer\LOS Installer\Resources\test.bat";
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                if (proc.Start())
                {
                    void outputCallback(string data)
                    {
                        textBoxLog.AppendText(data);
                        textBoxLog.AppendText(Environment.NewLine);
                    }
                    proc.OutputDataReceived += (_, e) => Invoke(outputCallback, e.Data);
                    proc.ErrorDataReceived += (_, e) => Invoke(outputCallback, e.Data);
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();

                }
                proc.WaitForExit();
            });
            button_bắt_đầu.Enabled = true;
        }
    }
}
