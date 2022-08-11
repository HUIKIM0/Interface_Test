
namespace Interface_Test
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsCountlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnInterfaceCallBack = new System.Windows.Forms.Button();
            this.btnStateLoopCheck = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInnerMain
            // 
            this.lblInnerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInnerMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInnerMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInnerMain.Location = new System.Drawing.Point(72, 95);
            this.lblInnerMain.Name = "lblInnerMain";
            this.lblInnerMain.Size = new System.Drawing.Size(406, 172);
            this.lblInnerMain.TabIndex = 0;
            this.lblInnerMain.Text = "dd";
            this.lblInnerMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgressBar,
            this.tsCountlbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(550, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgressBar
            // 
            this.tsProgressBar.Name = "tsProgressBar";
            this.tsProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // tsCountlbl
            // 
            this.tsCountlbl.Name = "tsCountlbl";
            this.tsCountlbl.Size = new System.Drawing.Size(30, 20);
            this.tsCountlbl.Text = "0%";
            // 
            // btnInterfaceCallBack
            // 
            this.btnInterfaceCallBack.Location = new System.Drawing.Point(75, 29);
            this.btnInterfaceCallBack.Name = "btnInterfaceCallBack";
            this.btnInterfaceCallBack.Size = new System.Drawing.Size(192, 51);
            this.btnInterfaceCallBack.TabIndex = 2;
            this.btnInterfaceCallBack.Text = "Interface CallBack Start";
            this.btnInterfaceCallBack.UseVisualStyleBackColor = true;
            // 
            // btnStateLoopCheck
            // 
            this.btnStateLoopCheck.Location = new System.Drawing.Point(286, 29);
            this.btnStateLoopCheck.Name = "btnStateLoopCheck";
            this.btnStateLoopCheck.Size = new System.Drawing.Size(192, 51);
            this.btnStateLoopCheck.TabIndex = 3;
            this.btnStateLoopCheck.Text = "Status Loop Check Start";
            this.btnStateLoopCheck.UseVisualStyleBackColor = true;
            this.btnStateLoopCheck.Click += new System.EventHandler(this.btnStateLoopCheck_Click);
            // 
            // InnerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 321);
            this.Controls.Add(this.btnStateLoopCheck);
            this.Controls.Add(this.btnInterfaceCallBack);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblInnerMain);
            this.Name = "InnerMain";
            this.Text = "InnerMain";
            this.Load += new System.EventHandler(this.InnerMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInnerMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel tsCountlbl;
        private System.Windows.Forms.Button btnInterfaceCallBack;
        private System.Windows.Forms.Button btnStateLoopCheck;
    }
}