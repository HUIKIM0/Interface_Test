
namespace Interface_Test
{
    partial class InnerSub
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
            this.lblInnerSub = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInnerSub
            // 
            this.lblInnerSub.BackColor = System.Drawing.SystemColors.Info;
            this.lblInnerSub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInnerSub.Location = new System.Drawing.Point(72, 47);
            this.lblInnerSub.Name = "lblInnerSub";
            this.lblInnerSub.Size = new System.Drawing.Size(245, 95);
            this.lblInnerSub.TabIndex = 0;
            this.lblInnerSub.Text = "ddd";
            this.lblInnerSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InnerSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 196);
            this.Controls.Add(this.lblInnerSub);
            this.Name = "InnerSub";
            this.Text = "dd";
            this.Load += new System.EventHandler(this.InnerSub_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInnerSub;
    }
}