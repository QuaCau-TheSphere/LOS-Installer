namespace LOS_Installer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_cài_đặt = new System.Windows.Forms.Button();
            this.UC_cài_đặt = new LOS_Installer.UC_cài_đặt();
            this.UC_giới_thiệu = new LOS_Installer.UC_giới_thiệu();
            this.buttonGiớiThiệu = new System.Windows.Forms.Button();
            this.button_gặp_nhau = new System.Windows.Forms.Button();
            this.UC_gặp_nhau = new LOS_Installer.UC_gặp_nhau();
            this.button_đóng = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LOS_Installer.Properties.Resources.Chào_mừng_đến_với_LOS__hanoi_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_cài_đặt
            // 
            this.button_cài_đặt.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cài_đặt.Location = new System.Drawing.Point(50, 50);
            this.button_cài_đặt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cài_đặt.Name = "button_cài_đặt";
            this.button_cài_đặt.Size = new System.Drawing.Size(118, 52);
            this.button_cài_đặt.TabIndex = 1;
            this.button_cài_đặt.Text = "Cài đặt";
            this.button_cài_đặt.UseVisualStyleBackColor = true;
            this.button_cài_đặt.Click += new System.EventHandler(this.button_cài_đặt_Click);
            // 
            // UC_cài_đặt
            // 
            this.UC_cài_đặt.Font = new System.Drawing.Font("SVN-Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UC_cài_đặt.Location = new System.Drawing.Point(174, 50);
            this.UC_cài_đặt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UC_cài_đặt.Name = "UC_cài_đặt";
            this.UC_cài_đặt.Size = new System.Drawing.Size(571, 332);
            this.UC_cài_đặt.TabIndex = 2;
            // 
            // UC_giới_thiệu
            // 
            this.UC_giới_thiệu.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UC_giới_thiệu.Location = new System.Drawing.Point(174, 50);
            this.UC_giới_thiệu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UC_giới_thiệu.Name = "UC_giới_thiệu";
            this.UC_giới_thiệu.Size = new System.Drawing.Size(571, 332);
            this.UC_giới_thiệu.TabIndex = 3;
            // 
            // buttonGiớiThiệu
            // 
            this.buttonGiớiThiệu.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGiớiThiệu.Location = new System.Drawing.Point(50, 110);
            this.buttonGiớiThiệu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGiớiThiệu.Name = "buttonGiớiThiệu";
            this.buttonGiớiThiệu.Size = new System.Drawing.Size(118, 52);
            this.buttonGiớiThiệu.TabIndex = 4;
            this.buttonGiớiThiệu.Text = "Giới thiệu";
            this.buttonGiớiThiệu.UseVisualStyleBackColor = true;
            this.buttonGiớiThiệu.Click += new System.EventHandler(this.buttonGiớiThiệu_Click);
            // 
            // button_gặp_nhau
            // 
            this.button_gặp_nhau.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_gặp_nhau.Location = new System.Drawing.Point(50, 170);
            this.button_gặp_nhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_gặp_nhau.Name = "button_gặp_nhau";
            this.button_gặp_nhau.Size = new System.Drawing.Size(118, 52);
            this.button_gặp_nhau.TabIndex = 5;
            this.button_gặp_nhau.Text = "Gặp nhau";
            this.button_gặp_nhau.UseVisualStyleBackColor = true;
            this.button_gặp_nhau.Click += new System.EventHandler(this.button_gặp_nhau_Click);
            // 
            // UC_gặp_nhau
            // 
            this.UC_gặp_nhau.BackColor = System.Drawing.SystemColors.Control;
            this.UC_gặp_nhau.Font = new System.Drawing.Font("SVN-Avo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UC_gặp_nhau.Location = new System.Drawing.Point(174, 50);
            this.UC_gặp_nhau.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UC_gặp_nhau.Name = "UC_gặp_nhau";
            this.UC_gặp_nhau.Size = new System.Drawing.Size(571, 332);
            this.UC_gặp_nhau.TabIndex = 7;
            // 
            // button_đóng
            // 
            this.button_đóng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_đóng.AutoSize = true;
            this.button_đóng.BackColor = System.Drawing.Color.Transparent;
            this.button_đóng.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_đóng.Font = new System.Drawing.Font("SVN-Avo", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_đóng.Location = new System.Drawing.Point(774, 0);
            this.button_đóng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_đóng.Name = "button_đóng";
            this.button_đóng.Size = new System.Drawing.Size(28, 25);
            this.button_đóng.TabIndex = 8;
            this.button_đóng.Text = "X";
            this.button_đóng.UseVisualStyleBackColor = false;
            this.button_đóng.Click += new System.EventHandler(this.button_đóng_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 553);
            this.ControlBox = false;
            this.Controls.Add(this.button_đóng);
            this.Controls.Add(this.UC_gặp_nhau);
            this.Controls.Add(this.button_gặp_nhau);
            this.Controls.Add(this.buttonGiớiThiệu);
            this.Controls.Add(this.UC_giới_thiệu);
            this.Controls.Add(this.UC_cài_đặt);
            this.Controls.Add(this.button_cài_đặt);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Vùng đất Quả Cầu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_cài_đặt;
        private UC_cài_đặt UC_cài_đặt;
        private UC_giới_thiệu UC_giới_thiệu;
        private Button buttonGiớiThiệu;
        private Button button_gặp_nhau;
        private UC_gặp_nhau UC_gặp_nhau;
        private Button button_đóng;
    }
}