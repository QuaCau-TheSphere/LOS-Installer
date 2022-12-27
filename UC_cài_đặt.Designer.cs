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
            this.buttonBắtĐầu = new System.Windows.Forms.Button();
            this.labelKhôngTắtNgang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_chọn_thư_mục
            // 
            this.button_chọn_thư_mục.AutoSize = true;
            this.button_chọn_thư_mục.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_chọn_thư_mục.Location = new System.Drawing.Point(437, 58);
            this.button_chọn_thư_mục.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button_chọn_thư_mục.Name = "button_chọn_thư_mục";
            this.button_chọn_thư_mục.Size = new System.Drawing.Size(97, 33);
            this.button_chọn_thư_mục.TabIndex = 0;
            this.button_chọn_thư_mục.Text = "Chọn...";
            this.button_chọn_thư_mục.UseVisualStyleBackColor = true;
            this.button_chọn_thư_mục.Click += new System.EventHandler(this.button_chọn_thư_mục_Click);
            // 
            // label_chọn_thư_mục_chứa_dữ_liệu
            // 
            this.label_chọn_thư_mục_chứa_dữ_liệu.AutoSize = true;
            this.label_chọn_thư_mục_chứa_dữ_liệu.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_chọn_thư_mục_chứa_dữ_liệu.Location = new System.Drawing.Point(30, 30);
            this.label_chọn_thư_mục_chứa_dữ_liệu.Name = "label_chọn_thư_mục_chứa_dữ_liệu";
            this.label_chọn_thư_mục_chứa_dữ_liệu.Size = new System.Drawing.Size(222, 23);
            this.label_chọn_thư_mục_chứa_dữ_liệu.TabIndex = 1;
            this.label_chọn_thư_mục_chứa_dữ_liệu.Text = "Chọn thư mục chứa dữ liệu";
            // 
            // textBox_thư_mục
            // 
            this.textBox_thư_mục.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_thư_mục.Location = new System.Drawing.Point(30, 58);
            this.textBox_thư_mục.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBox_thư_mục.Name = "textBox_thư_mục";
            this.textBox_thư_mục.Size = new System.Drawing.Size(401, 30);
            this.textBox_thư_mục.TabIndex = 2;
            this.textBox_thư_mục.TextChanged += new System.EventHandler(this.textBox_thư_mục_TextChanged);
            // 
            // buttonBắtĐầu
            // 
            this.buttonBắtĐầu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBắtĐầu.AutoSize = true;
            this.buttonBắtĐầu.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonBắtĐầu.Font = new System.Drawing.Font("SVN-Avo", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBắtĐầu.ForeColor = System.Drawing.Color.Black;
            this.buttonBắtĐầu.Location = new System.Drawing.Point(220, 104);
            this.buttonBắtĐầu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonBắtĐầu.Name = "buttonBắtĐầu";
            this.buttonBắtĐầu.Size = new System.Drawing.Size(143, 65);
            this.buttonBắtĐầu.TabIndex = 3;
            this.buttonBắtĐầu.Text = "Bắt đầu";
            this.buttonBắtĐầu.UseVisualStyleBackColor = false;
            this.buttonBắtĐầu.Click += new System.EventHandler(this.buttonBắtĐầu_Click);
            // 
            // labelKhôngTắtNgang
            // 
            this.labelKhôngTắtNgang.AutoSize = true;
            this.labelKhôngTắtNgang.Font = new System.Drawing.Font("SVN-Avo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKhôngTắtNgang.Location = new System.Drawing.Point(166, 174);
            this.labelKhôngTắtNgang.Name = "labelKhôngTắtNgang";
            this.labelKhôngTắtNgang.Size = new System.Drawing.Size(247, 16);
            this.labelKhôngTắtNgang.TabIndex = 5;
            this.labelKhôngTắtNgang.Text = "Vui lòng không tắt cửa sổ này khi đang cài";
            // 
            // UC_cài_đặt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelKhôngTắtNgang);
            this.Controls.Add(this.buttonBắtĐầu);
            this.Controls.Add(this.textBox_thư_mục);
            this.Controls.Add(this.label_chọn_thư_mục_chứa_dữ_liệu);
            this.Controls.Add(this.button_chọn_thư_mục);
            this.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "UC_cài_đặt";
            this.Size = new System.Drawing.Size(571, 332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_chọn_thư_mục;
        private Label label_chọn_thư_mục_chứa_dữ_liệu;
        private TextBox textBox_thư_mục;
        private Button buttonBắtĐầu;
        private Label labelKhôngTắtNgang;
    }
}
