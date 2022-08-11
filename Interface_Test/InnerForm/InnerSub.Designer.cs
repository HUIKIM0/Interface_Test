
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsCountlbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDelCallBack = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInnerSub
            // 
            this.lblInnerSub.BackColor = System.Drawing.SystemColors.Info;
            this.lblInnerSub.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInnerSub.Location = new System.Drawing.Point(45, 103);
            this.lblInnerSub.Name = "lblInnerSub";
            this.lblInnerSub.Size = new System.Drawing.Size(281, 94);
            this.lblInnerSub.TabIndex = 0;
            this.lblInnerSub.Text = "ddd";
            this.lblInnerSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsCountlbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 222);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(372, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 18);
            // 
            // tsCountlbl
            // 
            this.tsCountlbl.Name = "tsCountlbl";
            this.tsCountlbl.Size = new System.Drawing.Size(30, 20);
            this.tsCountlbl.Text = "0%";
            // 
            // btnDelCallBack
            // 
            this.btnDelCallBack.Location = new System.Drawing.Point(48, 33);
            this.btnDelCallBack.Name = "btnDelCallBack";
            this.btnDelCallBack.Size = new System.Drawing.Size(278, 50);
            this.btnDelCallBack.TabIndex = 2;
            this.btnDelCallBack.Text = "Delegate CallBack Start";
            this.btnDelCallBack.UseVisualStyleBackColor = true;
            // 
            // InnerSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 248);
            this.Controls.Add(this.btnDelCallBack);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblInnerSub);
            this.Name = "InnerSub";
            this.Text = "dd";
            this.Load += new System.EventHandler(this.InnerSub_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInnerSub;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsCountlbl;
        private System.Windows.Forms.Button btnDelCallBack;
    }
}