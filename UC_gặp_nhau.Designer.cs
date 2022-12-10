namespace LOS_Installer
{
    partial class UC_gặp_nhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_gặp_nhau));
            this.button_discord = new System.Windows.Forms.Button();
            this.button_facebook = new System.Windows.Forms.Button();
            this.textBoxGặpNhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_discord
            // 
            this.button_discord.BackgroundImage = global::LOS_Installer.Properties.Resources.discord;
            this.button_discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_discord.Location = new System.Drawing.Point(319, 197);
            this.button_discord.Name = "button_discord";
            this.button_discord.Size = new System.Drawing.Size(175, 89);
            this.button_discord.TabIndex = 2;
            this.button_discord.TabStop = false;
            this.button_discord.Click += new System.EventHandler(this.button_discord_Click);
            // 
            // button_facebook
            // 
            this.button_facebook.BackgroundImage = global::LOS_Installer.Properties.Resources.facebook2;
            this.button_facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_facebook.Location = new System.Drawing.Point(75, 197);
            this.button_facebook.Name = "button_facebook";
            this.button_facebook.Size = new System.Drawing.Size(175, 89);
            this.button_facebook.TabIndex = 3;
            this.button_facebook.UseVisualStyleBackColor = true;
            this.button_facebook.Click += new System.EventHandler(this.button_facebook_Click);
            // 
            // textBoxGặpNhau
            // 
            this.textBoxGặpNhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGặpNhau.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGặpNhau.Location = new System.Drawing.Point(30, 30);
            this.textBoxGặpNhau.Multiline = true;
            this.textBoxGặpNhau.Name = "textBoxGặpNhau";
            this.textBoxGặpNhau.ReadOnly = true;
            this.textBoxGặpNhau.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxGặpNhau.Size = new System.Drawing.Size(497, 149);
            this.textBoxGặpNhau.TabIndex = 4;
            this.textBoxGặpNhau.Text = resources.GetString("textBoxGặpNhau.Text");
            this.textBoxGặpNhau.WordWrap = false;
            this.textBoxGặpNhau.TextChanged += new System.EventHandler(this.textBoxGặpNhau_TextChanged);
            // 
            // UC_gặp_nhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.textBoxGặpNhau);
            this.Controls.Add(this.button_facebook);
            this.Controls.Add(this.button_discord);
            this.Name = "UC_gặp_nhau";
            this.Size = new System.Drawing.Size(558, 332);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_discord;
        private Button button_facebook;
        private TextBox textBoxGặpNhau;
    }
}
