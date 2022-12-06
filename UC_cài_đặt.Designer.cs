namespace LOS_Installer
{
    partial class UC_cài_đặt
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_chọn_thư_mục = new System.Windows.Forms.Button();
            this.label_chọn_thư_mục_chứa_dữ_liệu = new System.Windows.Forms.Label();
            this.textBox_thư_mục = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_chọn_thư_mục
            // 
            this.button_chọn_thư_mục.Location = new System.Drawing.Point(364, 44);
            this.button_chọn_thư_mục.Name = "button_chọn_thư_mục";
            this.button_chọn_thư_mục.Size = new System.Drawing.Size(75, 23);
            this.button_chọn_thư_mục.TabIndex = 0;
            this.button_chọn_thư_mục.Text = "Chọn...";
            this.button_chọn_thư_mục.UseVisualStyleBackColor = true;
            this.button_chọn_thư_mục.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_chọn_thư_mục_chứa_dữ_liệu
            // 
            this.label_chọn_thư_mục_chứa_dữ_liệu.AutoSize = true;
            this.label_chọn_thư_mục_chứa_dữ_liệu.Location = new System.Drawing.Point(26, 26);
            this.label_chọn_thư_mục_chứa_dữ_liệu.Name = "label_chọn_thư_mục_chứa_dữ_liệu";
            this.label_chọn_thư_mục_chứa_dữ_liệu.Size = new System.Drawing.Size(152, 15);
            this.label_chọn_thư_mục_chứa_dữ_liệu.TabIndex = 1;
            this.label_chọn_thư_mục_chứa_dữ_liệu.Text = "Chọn thư mục chứa dữ liệu";
            this.label_chọn_thư_mục_chứa_dữ_liệu.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_thư_mục
            // 
            this.textBox_thư_mục.Location = new System.Drawing.Point(26, 45);
            this.textBox_thư_mục.Name = "textBox_thư_mục";
            this.textBox_thư_mục.Size = new System.Drawing.Size(332, 23);
            this.textBox_thư_mục.TabIndex = 2;
            // 
            // UC_cài_đặt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_thư_mục);
            this.Controls.Add(this.label_chọn_thư_mục_chứa_dữ_liệu);
            this.Controls.Add(this.button_chọn_thư_mục);
            this.Name = "UC_cài_đặt";
            this.Size = new System.Drawing.Size(460, 271);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_chọn_thư_mục;
        private Label label_chọn_thư_mục_chứa_dữ_liệu;
        private TextBox textBox_thư_mục;
    }
}
