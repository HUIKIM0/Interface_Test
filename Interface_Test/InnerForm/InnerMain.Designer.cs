
namespace Interface_Test.InnerForm
{
    partial class InnerMain
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
            this.lblInnerMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInnerMain
            // 
            this.lblInnerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInnerMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInnerMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInnerMain.Location = new System.Drawing.Point(72, 47);
            this.lblInnerMain.Name = "lblInnerMain";
            this.lblInnerMain.Size = new System.Drawing.Size(245, 95);
            this.lblInnerMain.TabIndex = 0;
            this.lblInnerMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InnerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 196);
            this.Controls.Add(this.lblInnerMain);
            this.Name = "InnerMain";
            this.Text = "InnerMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInnerMain;
    }
}