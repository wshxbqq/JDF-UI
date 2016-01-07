using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
namespace JDF_UI
{

    public partial class Form1 : Form
    {


         
        public static List<SelectedTreeNodeInfo> treeNodeList { get; set; }

        public bool isLatest = true;
        public string latestVersion="";

        public int statusFlag = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
 
        


        public void setCurrentPath(string path){
            uC_JDF_UserInterface1.setCurrentPath(path);
        }

        private void uC_FolderTree1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_FolderTree1.treeViewDirectory.NodeMouseClick += treeViewDirectory_NodeMouseClick;
            uC_FolderTree1.treeViewDirectory.NodeMouseDoubleClick += treeViewDirectory_NodeMouseDoubleClick;
            uC_FolderTree1.treeViewDirectory.MouseLeave += treeViewDirectory_MouseLeave;
            uC_FolderTree1.initwithRoot();

            treeNodeList = new List<SelectedTreeNodeInfo>();

            backgroundWorker1.RunWorkerAsync();


            Rectangle rect = Screen.GetWorkingArea(this);
            Point p = new Point((rect.Width-this.Width)/2, (rect.Height-this.Height)/2);



            this.Location = p;

            

        }

        void treeViewDirectory_MouseLeave(object sender, EventArgs e)
        {
            //Common.form1.uC_Editor1.setWbFocus();
        }

        void treeViewDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
         
            //if (e.Node.Tag != null)
            //{
            //    var pathName = e.Node.Tag.ToString();
            //    this.setCurrentPath(pathName);

            //    if (File.Exists(pathName))
            //    {
            //        this.showFile(pathName);
            //        this.showEditorView();
            //        this.uC_TitleLogo1.adjustSwitchBtn();
            //    }   


            //}
        }



        void treeViewDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {


                if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
                {
   
                    addNodeToShiftMutiList(e.Node);


                    if (this.uC_FolderTree1.PreSelectedNode!= null)
                    {
                        addNodeToShiftMutiList(this.uC_FolderTree1.treeViewDirectory.SelectedNode);
 
                    }

                    
                   



                    this.uC_JDF_UserInterface1.setCurrentPath(treeNodeList.Count.ToString()+" 项目");
                    return;
                }
                else {
                    foreach (SelectedTreeNodeInfo tn in treeNodeList)
                    {
                        tn.tn.ImageIndex = tn.imgIndex;
                    
                    }

                    treeNodeList.Clear();
                
                }
                 var pathName = e.Node.Tag.ToString();
                this.setCurrentPath(pathName);
                this.uC_FolderTree1.PreSelectedNode = this.uC_FolderTree1.treeViewDirectory.SelectedNode;
               

            }
        }

        public bool isSelectedMuti(TreeNode tn)
        {
            bool flag = false;
            foreach (var item in treeNodeList)
            {
                if (item.tn == tn)
                {
                    flag = true;
                    
                    item.tn.ImageIndex = item.imgIndex;
                    treeNodeList.Remove(item);
                    break;
                }

            }

            return flag;
        
        }


        public void addNodeToShiftMutiList(TreeNode tn)
        {
            SelectedTreeNodeInfo tn1 = new SelectedTreeNodeInfo();
            tn1.imgIndex = tn.ImageIndex;
            tn1.tn = tn;
            tn1.tn.ImageIndex = 3;
            bool flag = false;
            foreach (var item in treeNodeList) {
                if (item.tn == tn)
                {
                    flag = true;
                
                    

                }

            }
            if (!flag)
            {
                treeNodeList.Add(tn1);
            }
            
    
        }

       public  void showEditorView() {
            splitContainer2.Visible = false;
            uC_Editor1.Visible = true;
            uC_Editor1.Dock = DockStyle.Fill;
            statusFlag = 1;
        
        }
       public void showConsoleView()
       {
            splitContainer2.Visible = true;
            uC_Editor1.Visible = false;
            uC_Editor1.Dock = DockStyle.Fill;
            statusFlag = 0;
        
        }

       public void showFile(string path) {
           uC_Editor1.addNewTab(path);
       
       }

       private void Form1_FormClosed(object sender, FormClosedEventArgs e)
       {

           uC_Console1.closeHold();
       }

       private void Form1_MinimumSizeChanged(object sender, EventArgs e)
       {
           MessageBox.Show("asdasd");
       }

       private void Form1_Deactivate(object sender, EventArgs e)
       {
           //if (this.WindowState == FormWindowState.Minimized) {
           //    this.Hide();
           //    Form2 f2 = new Form2();
           //    f2.WindowState = FormWindowState.Normal;
           //    f2.Show();
           //    f2.Activate();
           //}
       }

       public ToolStripProgressBar busy_bar {
           get { return this.toolStripProgressBar_isbusy; }
       }

       private void Form1_FormClosing(object sender, FormClosingEventArgs e)
       {
           uC_Console1.closeHold();

       }

       private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
       {
           MessageBox.Show("JDF UI 工具 v1.0");
       }

       private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
       {
           try
           {
               string lV = Common.getLocationVersion();
               string RV = Common.getRemoteVersion();
               if (lV != RV)
               {
                   latestVersion = RV;
                
               }
         
           }
           catch (Exception ex)
           {

           }
       }

       private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
       {
           if (latestVersion!="") {
               uC_TitleLogo1.label_not_latest.Text = "您的JDF不是最新 v" + latestVersion;
           }
       }

       private void Form1_ResizeEnd(object sender, EventArgs e)
       {
        
       }

     

   
 

    }

    public class SelectedTreeNodeInfo
    {
        public int imgIndex { get; set; }
        public TreeNode tn { get; set; }
    }
        
}
