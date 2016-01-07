namespace JDF_UI.UC
{
    partial class UC_FolderTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_FolderTree));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeViewDirectory = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageButton1 = new System.Windows.Forms.ImageButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "blue16_031.jpg");
            this.imageList1.Images.SetKeyName(1, "blue16_026.jpg");
            this.imageList1.Images.SetKeyName(2, "blue16_018.jpg");
            this.imageList1.Images.SetKeyName(3, "selected.jpg");
            // 
            // treeViewDirectory
            // 
            this.treeViewDirectory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.treeViewDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDirectory.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewDirectory.Location = new System.Drawing.Point(3, 30);
            this.treeViewDirectory.Margin = new System.Windows.Forms.Padding(0);
            this.treeViewDirectory.Name = "treeViewDirectory";
            this.treeViewDirectory.Size = new System.Drawing.Size(244, 479);
            this.treeViewDirectory.TabIndex = 0;
            this.treeViewDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewDirectory_BeforeExpand);
            this.treeViewDirectory.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDirectory_AfterExpand);
            this.treeViewDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewDirectory_NodeMouseClick);
            this.treeViewDirectory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewDirectory_NodeMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageButton1);
            this.groupBox1.Controls.Add(this.treeViewDirectory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 512);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目录";
            // 
            // imageButton1
            // 
            this.imageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageButton1.DownImage = null;
            this.imageButton1.HoverImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.HoverImage")));
            this.imageButton1.Location = new System.Drawing.Point(58, 0);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.NormalImage = global::JDF_UI.Properties.Resources.flash;
            this.imageButton1.Size = new System.Drawing.Size(25, 25);
            this.imageButton1.TabIndex = 2;
            this.imageButton1.TabStop = false;
            this.imageButton1.Click += new System.EventHandler(this.imageButton1_Click);
            // 
            // UC_FolderTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_FolderTree";
            this.Size = new System.Drawing.Size(250, 512);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.TreeView treeViewDirectory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageButton imageButton1;

    }
}
