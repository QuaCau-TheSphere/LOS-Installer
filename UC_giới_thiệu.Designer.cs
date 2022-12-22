namespace LOS_Installer
{
    partial class UC_giới_thiệu
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
            this.richTextBoxGiớiThiệu = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxGiớiThiệu
            // 
            this.richTextBoxGiớiThiệu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxGiớiThiệu.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxGiớiThiệu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxGiớiThiệu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxGiớiThiệu.Location = new System.Drawing.Point(30, 30);
            this.richTextBoxGiớiThiệu.Margin = new System.Windows.Forms.Padding(29, 31, 29, 31);
            this.richTextBoxGiớiThiệu.Name = "richTextBoxGiớiThiệu";
            this.richTextBoxGiớiThiệu.ReadOnly = true;
            this.richTextBoxGiớiThiệu.Size = new System.Drawing.Size(767, 448);
            this.richTextBoxGiớiThiệu.TabIndex = 1;
            this.richTextBoxGiớiThiệu.Text = "";
            this.richTextBoxGiớiThiệu.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxGiớiThiệu_LinkClicked);
            // 
            // UC_giới_thiệu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxGiớiThiệu);
            this.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_giới_thiệu";
            this.Size = new System.Drawing.Size(797, 509);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxGiớiThiệu;
    }
}
