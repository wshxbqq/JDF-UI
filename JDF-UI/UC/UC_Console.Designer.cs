namespace JDF_UI.UC
{
    partial class UC_Console
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxCmd = new System.Windows.Forms.RichTextBox();
            this.backgroundWorkerConsole = new System.ComponentModel.BackgroundWorker();
            this.timer_holder = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxCmd
            // 
            this.richTextBoxCmd.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxCmd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxCmd.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCmd.Location = new System.Drawing.Point(3, 30);
            this.richTextBoxCmd.Name = "richTextBoxCmd";
            this.richTextBoxCmd.Size = new System.Drawing.Size(411, 254);
            this.richTextBoxCmd.TabIndex = 0;
            this.richTextBoxCmd.Text = "";
            // 
            // backgroundWorkerConsole
            // 
            this.backgroundWorkerConsole.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerConsole_DoWork);
            this.backgroundWorkerConsole.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerConsole_RunWorkerCompleted);
            // 
            // timer_holder
            // 
            this.timer_holder.Enabled = true;
            this.timer_holder.Interval = 200;
            this.timer_holder.Tick += new System.EventHandler(this.timer_holder_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.richTextBoxCmd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制台";
            // 
            // UC_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Console";
            this.Size = new System.Drawing.Size(417, 287);
            this.Load += new System.EventHandler(this.UC_Console_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBoxCmd;
        private System.ComponentModel.BackgroundWorker backgroundWorkerConsole;
        private System.Windows.Forms.Timer timer_holder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
