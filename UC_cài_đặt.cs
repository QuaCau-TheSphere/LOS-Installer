using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;

namespace LOS_Installer
{
    public partial class UC_cài_đặt : UserControl
    {
        string path = string.Empty;
        public UC_cài_đặt()
        {
            InitializeComponent();
            textBox_thư_mục.Text = "D:\\";
            //textBox_thư_mục.Text = "C:\\Users\\ooker\\Documents\\1 Công việc";
            path = textBox_thư_mục.Text;
        }

        public void button_chọn_thư_mục_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                InitialDirectory = textBox_thư_mục.Text,
                IsFolderPicker = true
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                textBox_thư_mục.Text = dialog.FileName;
            }
            path = textBox_thư_mục.Text;
        }
        public async void buttonBắtĐầu_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Thư mục không tồn tại");
                return;
            }
            //Directory.SetCurrentDirectory(path);
            label_chọn_thư_mục_chứa_dữ_liệu.ForeColor = SystemColors.ControlDark;
            button_chọn_thư_mục.Enabled = false;
            textBox_thư_mục.Enabled = false;
            buttonBắtĐầu.Enabled = false;
            buttonBắtĐầu.Text = "Đang cài...";

            var proc = new Process();
            //proc.StartInfo.FileName = @"Resources\Script test.bat";
            proc.StartInfo.FileName = @"Resources\2. Cài đặt Obsidian và Git.bat";
            proc.StartInfo.Arguments = "\"" + path + "\"";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
            proc.WaitForExit();

            proc.StartInfo.FileName = @"Resources\3. Tải dữ liệu.bat";
            proc.Start();
            proc.WaitForExit();

            proc.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%localappdata%\Obsidian\Obsidian.exe");
            proc.StartInfo.Arguments = @"""obsidian://vault/Land of Spheres/== Bản đồ dành cho người mới ==""";
            proc.Start();
            buttonBắtĐầu.Text = "Đã cài xong";

            //await Task.Run(() =>
            //{
                //proc.StartInfo.CreaterNoWindow = true;
                //proc.StartInfo.RedirectStandardOutput = true;
                //proc.StartInfo.RedirectStandardError = true;
                //if (proc.Start())
                //{
                //    void outputCallback(string data)
                //    {
                //        textBoxLog.AppendText(data);
                //        textBoxLog.AppendText(Environment.NewLine);
                //    }
                //    proc.OutputDataReceived += (_, e) => Invoke(outputCallback, e.Data);
                //    proc.ErrorDataReceived += (_, e) => Invoke(outputCallback, e.Data);
                //    proc.BeginOutputReadLine();
                //    proc.BeginErrorReadLine();

                //}
            //    proc.WaitForExit();
            //});
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_thư_mục_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
