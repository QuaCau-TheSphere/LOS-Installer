namespace LOS_Installer
{
    partial class UC_triết_lý
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
            this.richTextBoxTriếtLý = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxTriếtLý
            // 
            this.richTextBoxTriếtLý.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTriếtLý.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxTriếtLý.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTriếtLý.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxTriếtLý.Location = new System.Drawing.Point(43, 46);
            this.richTextBoxTriếtLý.Margin = new System.Windows.Forms.Padding(29, 31, 29, 31);
            this.richTextBoxTriếtLý.Name = "richTextBoxTriếtLý";
            this.richTextBoxTriếtLý.ReadOnly = true;
            this.richTextBoxTriếtLý.Size = new System.Drawing.Size(754, 414);
            this.richTextBoxTriếtLý.TabIndex = 1;
            this.richTextBoxTriếtLý.Text = "";
            this.richTextBoxTriếtLý.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // UC_triết_lý
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxTriếtLý);
            this.Font = new System.Drawing.Font("SVN-Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_triết_lý";
            this.Size = new System.Drawing.Size(797, 509);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBoxTriếtLý;
    }
}
