namespace ArmBot
{
    partial class commandview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCMD = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listCMD
            // 
            this.listCMD.BackColor = System.Drawing.SystemColors.MenuText;
            this.listCMD.ForeColor = System.Drawing.Color.White;
            this.listCMD.FormattingEnabled = true;
            this.listCMD.Location = new System.Drawing.Point(2, 2);
            this.listCMD.Name = "listCMD";
            this.listCMD.Size = new System.Drawing.Size(944, 485);
            this.listCMD.TabIndex = 0;
            // 
            // commandview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 489);
            this.Controls.Add(this.listCMD);
            this.Name = "commandview";
            this.Text = "commandview";
            this.Load += new System.EventHandler(this.commandview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listCMD;
    }
}