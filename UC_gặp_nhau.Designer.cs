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
            this.richTextBox_gặp_nhau = new System.Windows.Forms.RichTextBox();
            this.button_discord = new System.Windows.Forms.Button();
            this.button_facebook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_gặp_nhau
            // 
            this.richTextBox_gặp_nhau.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_gặp_nhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_gặp_nhau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_gặp_nhau.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox_gặp_nhau.Location = new System.Drawing.Point(20, 20);
            this.richTextBox_gặp_nhau.Name = "richTextBox_gặp_nhau";
            this.richTextBox_gặp_nhau.ReadOnly = true;
            this.richTextBox_gặp_nhau.Size = new System.Drawing.Size(403, 215);
            this.richTextBox_gặp_nhau.TabIndex = 0;
            this.richTextBox_gặp_nhau.Text = resources.GetString("richTextBox_gặp_nhau.Text");
            this.richTextBox_gặp_nhau.Enter += new System.EventHandler(this.richTextBox_gặp_nhau_Enter);
            // 
            // button_discord
            // 
            this.button_discord.BackgroundImage = global::LOS_Installer.Properties.Resources.discord;
            this.button_discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_discord.Location = new System.Drawing.Point(254, 191);
            this.button_discord.Name = "button_discord";
            this.button_discord.Size = new System.Drawing.Size(100, 50);
            this.button_discord.TabIndex = 2;
            this.button_discord.TabStop = false;
            this.button_discord.Click += new System.EventHandler(this.button_discord_Click);
            // 
            // button_facebook
            // 
            this.button_facebook.BackgroundImage = global::LOS_Installer.Properties.Resources.facebook2;
            this.button_facebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_facebook.Location = new System.Drawing.Point(82, 191);
            this.button_facebook.Name = "button_facebook";
            this.button_facebook.Size = new System.Drawing.Size(100, 50);
            this.button_facebook.TabIndex = 3;
            this.button_facebook.UseVisualStyleBackColor = true;
            this.button_facebook.Click += new System.EventHandler(this.button_facebook_Click);
            // 
            // UC_gặp_nhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button_facebook);
            this.Controls.Add(this.button_discord);
            this.Controls.Add(this.richTextBox_gặp_nhau);
            this.Name = "UC_gặp_nhau";
            this.Size = new System.Drawing.Size(460, 271);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox_gặp_nhau;
        private Button button_discord;
        private Button button_facebook;
    }
}
