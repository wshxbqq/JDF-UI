namespace JDF_UI.UC
{
    partial class UC_JDF_UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_JDF_UserInterface));
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonDebug = new System.Windows.Forms.RadioButton();
            this.radioButtonRelease = new System.Windows.Forms.RadioButton();
            this.imageButton_btn_output = new System.Windows.Forms.ImageButton();
            this.imageButton_btn_upload = new System.Windows.Forms.ImageButton();
            this.imageButton_btn_clear = new System.Windows.Forms.ImageButton();
            this.imageButton_btn_close = new System.Windows.Forms.ImageButton();
            this.imageButton_btn_complie = new System.Windows.Forms.ImageButton();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_upload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_complie)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Controls.Add(this.groupBox1);
            this.panel_main.Controls.Add(this.imageButton_btn_output);
            this.panel_main.Controls.Add(this.imageButton_btn_upload);
            this.panel_main.Controls.Add(this.imageButton_btn_clear);
            this.panel_main.Controls.Add(this.imageButton_btn_close);
            this.panel_main.Controls.Add(this.imageButton_btn_complie);
            this.panel_main.Controls.Add(this.labelCurrentPath);
            this.panel_main.Controls.Add(this.label2);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(663, 394);
            this.panel_main.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 36);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(370, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 73);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发布参数";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonDebug);
            this.panel1.Controls.Add(this.radioButtonRelease);
            this.panel1.Location = new System.Drawing.Point(19, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 38);
            this.panel1.TabIndex = 10;
            // 
            // radioButtonDebug
            // 
            this.radioButtonDebug.AutoSize = true;
            this.radioButtonDebug.Location = new System.Drawing.Point(12, 10);
            this.radioButtonDebug.Name = "radioButtonDebug";
            this.radioButtonDebug.Size = new System.Drawing.Size(67, 21);
            this.radioButtonDebug.TabIndex = 9;
            this.radioButtonDebug.Text = "Debug";
            this.radioButtonDebug.UseVisualStyleBackColor = true;
            // 
            // radioButtonRelease
            // 
            this.radioButtonRelease.AutoSize = true;
            this.radioButtonRelease.Checked = true;
            this.radioButtonRelease.Location = new System.Drawing.Point(91, 10);
            this.radioButtonRelease.Name = "radioButtonRelease";
            this.radioButtonRelease.Size = new System.Drawing.Size(69, 21);
            this.radioButtonRelease.TabIndex = 10;
            this.radioButtonRelease.TabStop = true;
            this.radioButtonRelease.Text = "release";
            this.radioButtonRelease.UseVisualStyleBackColor = true;
            // 
            // imageButton_btn_output
            // 
            this.imageButton_btn_output.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton_btn_output.DownImage = null;
            this.imageButton_btn_output.HoverImage = global::JDF_UI.Properties.Resources.btn_release_1;
            this.imageButton_btn_output.Location = new System.Drawing.Point(61, 183);
            this.imageButton_btn_output.Name = "imageButton_btn_output";
            this.imageButton_btn_output.NormalImage = global::JDF_UI.Properties.Resources.btn_release;
            this.imageButton_btn_output.Size = new System.Drawing.Size(102, 38);
            this.imageButton_btn_output.TabIndex = 16;
            this.imageButton_btn_output.TabStop = false;
            this.imageButton_btn_output.Click += new System.EventHandler(this.imageButton_btn_output_Click);
            // 
            // imageButton_btn_upload
            // 
            this.imageButton_btn_upload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton_btn_upload.DownImage = null;
            this.imageButton_btn_upload.HoverImage = global::JDF_UI.Properties.Resources.btn_output_1;
            this.imageButton_btn_upload.Location = new System.Drawing.Point(211, 183);
            this.imageButton_btn_upload.Name = "imageButton_btn_upload";
            this.imageButton_btn_upload.NormalImage = global::JDF_UI.Properties.Resources.btn_output;
            this.imageButton_btn_upload.Size = new System.Drawing.Size(102, 38);
            this.imageButton_btn_upload.TabIndex = 15;
            this.imageButton_btn_upload.TabStop = false;
            this.imageButton_btn_upload.Click += new System.EventHandler(this.imageButton_btn_upload_Click);
            // 
            // imageButton_btn_clear
            // 
            this.imageButton_btn_clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton_btn_clear.DownImage = null;
            this.imageButton_btn_clear.HoverImage = global::JDF_UI.Properties.Resources.btn_clear_1;
            this.imageButton_btn_clear.Location = new System.Drawing.Point(370, 103);
            this.imageButton_btn_clear.Name = "imageButton_btn_clear";
            this.imageButton_btn_clear.NormalImage = global::JDF_UI.Properties.Resources.btn_clear;
            this.imageButton_btn_clear.Size = new System.Drawing.Size(102, 38);
            this.imageButton_btn_clear.TabIndex = 14;
            this.imageButton_btn_clear.TabStop = false;
            this.imageButton_btn_clear.Click += new System.EventHandler(this.imageButton_btn_clear_Click);
            // 
            // imageButton_btn_close
            // 
            this.imageButton_btn_close.BackColor = System.Drawing.Color.Transparent;
            this.imageButton_btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton_btn_close.DownImage = null;
            this.imageButton_btn_close.HoverImage = global::JDF_UI.Properties.Resources.bnt_close_1;
            this.imageButton_btn_close.Location = new System.Drawing.Point(211, 103);
            this.imageButton_btn_close.Name = "imageButton_btn_close";
            this.imageButton_btn_close.NormalImage = global::JDF_UI.Properties.Resources.bnt_close;
            this.imageButton_btn_close.Size = new System.Drawing.Size(102, 38);
            this.imageButton_btn_close.TabIndex = 13;
            this.imageButton_btn_close.TabStop = false;
            this.imageButton_btn_close.Click += new System.EventHandler(this.imageButton_btn_close_Click);
            // 
            // imageButton_btn_complie
            // 
            this.imageButton_btn_complie.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton_btn_complie.DownImage = null;
            this.imageButton_btn_complie.HoverImage = global::JDF_UI.Properties.Resources.btn_compile_1;
            this.imageButton_btn_complie.Location = new System.Drawing.Point(61, 103);
            this.imageButton_btn_complie.Name = "imageButton_btn_complie";
            this.imageButton_btn_complie.NormalImage = global::JDF_UI.Properties.Resources.btn_compile;
            this.imageButton_btn_complie.Size = new System.Drawing.Size(102, 38);
            this.imageButton_btn_complie.TabIndex = 12;
            this.imageButton_btn_complie.TabStop = false;
            this.imageButton_btn_complie.Click += new System.EventHandler(this.imageButton_btn_complie_Click);
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCurrentPath.ForeColor = System.Drawing.Color.DimGray;
            this.labelCurrentPath.Location = new System.Drawing.Point(165, 16);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(92, 22);
            this.labelCurrentPath.TabIndex = 8;
            this.labelCurrentPath.Text = "D:/abc.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "当前目录：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "初始化选项：";
            // 
            // UC_JDF_UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_main);
            this.Name = "UC_JDF_UserInterface";
            this.Size = new System.Drawing.Size(663, 394);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_upload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton_btn_complie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonRelease;
        private System.Windows.Forms.RadioButton radioButtonDebug;
        private System.Windows.Forms.ImageButton imageButton_btn_complie;
        private System.Windows.Forms.ImageButton imageButton_btn_clear;
        private System.Windows.Forms.ImageButton imageButton_btn_close;
        private System.Windows.Forms.ImageButton imageButton_btn_output;
        private System.Windows.Forms.ImageButton imageButton_btn_upload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
