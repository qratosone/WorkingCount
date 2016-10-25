namespace WorkingCount
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAccess = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(12, 123);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(583, 385);
            this.txtInput.TabIndex = 0;
            // 
            // btnAccess
            // 
            this.btnAccess.Location = new System.Drawing.Point(22, 28);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(120, 59);
            this.btnAccess.TabIndex = 1;
            this.btnAccess.Text = "获取章节数";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(277, 39);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(53, 12);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "章节计数";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 520);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.txtInput);
            this.Name = "frmMain";
            this.Text = "章节计数器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label lblCount;
    }
}

