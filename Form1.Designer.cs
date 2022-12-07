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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_cài_đặt = new System.Windows.Forms.Button();
            this.UC_cài_đặt = new LOS_Installer.UC_cài_đặt();
            this.UC_triết_lý = new LOS_Installer.UC_triết_lý();
            this.button_triết_lý = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LOS_Installer.Properties.Resources.Chào_mừng_đến_với_LOS__hanoi_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_cài_đặt
            // 
            this.button_cài_đặt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cài_đặt.Location = new System.Drawing.Point(42, 42);
            this.button_cài_đặt.Name = "button_cài_đặt";
            this.button_cài_đặt.Size = new System.Drawing.Size(104, 38);
            this.button_cài_đặt.TabIndex = 1;
            this.button_cài_đặt.Text = "Cài đặt";
            this.button_cài_đặt.UseVisualStyleBackColor = true;
            this.button_cài_đặt.Click += new System.EventHandler(this.button_cài_đặt_Click);
            // 
            // UC_cài_đặt
            // 
            this.UC_cài_đặt.Location = new System.Drawing.Point(152, 42);
            this.UC_cài_đặt.Name = "UC_cài_đặt";
            this.UC_cài_đặt.Size = new System.Drawing.Size(460, 271);
            this.UC_cài_đặt.TabIndex = 2;
            this.UC_cài_đặt.Load += new System.EventHandler(this.UC_cài_đặt_Load);
            // 
            // UC_triết_lý
            // 
            this.UC_triết_lý.Location = new System.Drawing.Point(152, 42);
            this.UC_triết_lý.Name = "UC_triết_lý";
            this.UC_triết_lý.Size = new System.Drawing.Size(460, 271);
            this.UC_triết_lý.TabIndex = 3;
            // 
            // button_triết_lý
            // 
            this.button_triết_lý.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_triết_lý.Location = new System.Drawing.Point(42, 86);
            this.button_triết_lý.Name = "button_triết_lý";
            this.button_triết_lý.Size = new System.Drawing.Size(104, 38);
            this.button_triết_lý.TabIndex = 4;
            this.button_triết_lý.Text = "Triết lý";
            this.button_triết_lý.UseVisualStyleBackColor = true;
            this.button_triết_lý.Click += new System.EventHandler(this.button_triết_lý_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.button_triết_lý);
            this.Controls.Add(this.UC_triết_lý);
            this.Controls.Add(this.UC_cài_đặt);
            this.Controls.Add(this.button_cài_đặt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button button_cài_đặt;
        private UC_cài_đặt UC_cài_đặt;
        private UC_triết_lý UC_triết_lý;
        private Button button_triết_lý;
    }
}