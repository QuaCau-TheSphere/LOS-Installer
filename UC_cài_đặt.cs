﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LOS_Installer
{
    public partial class UC_cài_đặt : UserControl
    {
        string path = string.Empty;
        public UC_cài_đặt()
        {
            InitializeComponent();
            textBoxLog.Visible = false;
            textBox_thư_mục.Text = "D:\\";
            path = textBox_thư_mục.Text;
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
            //if (path == string.Empty ) {
            //    MessageBox.Show("Hãy chọn thư mục chứa dữ liệu");
            //    return;
            //}
            Directory.SetCurrentDirectory(path);
            textBoxLog.Visible = true;
            button_bắt_đầu.Enabled = false;
            await Task.Run(() => {
                var proc = new Process();
                string tempFile = path + "temporary_script.bat";
                File.WriteAllText(tempFile, Properties.Resources.Script_cài_chương_trình);
                proc.StartInfo.FileName = @"temporary_script.bat";
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.Arguments = path;
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
                File.Delete(tempFile);
            });
            button_bắt_đầu.Enabled = true;
        }
    }
}
