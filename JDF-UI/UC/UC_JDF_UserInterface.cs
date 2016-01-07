using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace JDF_UI.UC
{
    public partial class UC_JDF_UserInterface : UserControl
    {
   
      

        string currentFilePath;
        public UC_JDF_UserInterface()
        {
            InitializeComponent();
        }
        public void setCurrentPath(string path)
        {
            currentFilePath = path;
            labelCurrentPath.Text = currentFilePath;
        }

 

        string getJDFPath(string path) {
            string result="";
            if (File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
                DirectoryInfo di = fi.Directory;
                while (di.GetFiles("config.json", SearchOption.TopDirectoryOnly).Length <= 0)
                {

                    di = di.Parent;
                    if (di==null)
                    {
                        return result;
                    }
                }
                result = di.FullName;
            }
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                while (di.GetFiles("config.json", SearchOption.TopDirectoryOnly).Length <= 0)
                {
                    di = di.Parent;
                    if (di == null)
                    {
                        return result;
                    }
                }
                result = di.FullName;
            
            }



            return result;
        }
 

   

        private void imageButton_btn_complie_Click(object sender, EventArgs e)
        {
            if (Form1.treeNodeList.Count > 0)
            {
                currentFilePath = Form1.treeNodeList[0].tn.Tag.ToString();
            }

            var jdfPath = getJDFPath(currentFilePath);
            if (jdfPath == "")
            {
                MessageBox.Show(currentFilePath + Environment.NewLine + "这不是一个JDF工程目录", "当前信息");
                return;
            }
            Common.form1.uC_Console1.closeHold();

            //SimpleHTTPServer sHttp = new SimpleHTTPServer(currentFilePath);
            //Common.form1.uC_Console1.richTextBoxCmd.Text = "Start At " + currentFilePath + Environment.NewLine + "Port:http://localhost:" + sHttp.Port.ToString();
            //System.Diagnostics.Process.Start("chrome.exe", "http://localhost:" + sHttp.Port.ToString()); 
            var diskName = currentFilePath.Split('\\')[0];
            var jdfCmd = diskName + " &cd " + jdfPath + "& jdf b";

            Common.form1.uC_Console1.execHoldAnsy(jdfCmd);
 


        }

        private void imageButton_btn_close_Click(object sender, EventArgs e)
        {
    
            Common.form1.uC_Console1.richTextBoxCmd.Text = "已关闭";
            Common.form1.uC_Console1.closeHold();

            
            
        }

        private void imageButton_btn_clear_Click(object sender, EventArgs e)
        {
            var jdfPath = getJDFPath(currentFilePath);
            if (jdfPath == "")
            {
                MessageBox.Show(currentFilePath + Environment.NewLine + "这不是一个JDF工程目录", "当前信息");
                return;
            }
            var diskName = currentFilePath.Split('\\')[0];
            var jdfCmd = diskName + " &cd " + jdfPath + "& jdf clean";



            Common.form1.uC_Console1.execAnsy(jdfCmd);
        }

        private void imageButton_btn_output_Click(object sender, EventArgs e)
        {

            if (Form1.treeNodeList.Count>0)
            {
                currentFilePath = Form1.treeNodeList[0].tn.Tag.ToString();
            }

            var jdfPath = getJDFPath(currentFilePath);
            if (jdfPath == "")
            {
                MessageBox.Show(currentFilePath + Environment.NewLine + "这不是一个JDF工程目录", "当前信息");
                return;
            }

            Common.form1.uC_Console1.closeHold();


            var diskName = currentFilePath.Split('\\')[0];

            string targetPath = currentFilePath.Replace(jdfPath, string.Empty);
            targetPath = targetPath.Trim('\\');
            if (Form1.treeNodeList.Count > 0) {
                targetPath = "";
                foreach(var tn in Form1.treeNodeList ){
                    targetPath += tn.tn.Tag.ToString().Replace(jdfPath, string.Empty).Trim('\\') + ",";

                }
                targetPath = targetPath.Trim(',');
            }


            var jdfCmd = diskName + " &cd " + jdfPath + "& jdf o " + targetPath;
            if (targetPath.Contains("html") || targetPath=="")
            {
                jdfCmd = diskName + " &cd " + jdfPath + "& jdf o " + targetPath + " -html ";
            }
            

            if (radioButtonDebug.Checked)
            {
                jdfCmd += " -debug";

            }

            Common.form1.busy_bar.Visible = true;
          
            Common.form1.uC_Console1.execAnsy(jdfCmd);

 
          
           
        }

        private void imageButton_btn_upload_Click(object sender, EventArgs e)
        {
            if (Form1.treeNodeList.Count > 0)
            {
                currentFilePath = Form1.treeNodeList[0].tn.Tag.ToString();
            }


            var jdfPath = getJDFPath(currentFilePath);
            if (jdfPath == "")
            {
                MessageBox.Show(currentFilePath + Environment.NewLine + "这不是一个JDF工程目录", "当前信息");
                return;
            }

            Common.form1.uC_Console1.closeHold();
            var diskName = currentFilePath.Split('\\')[0];

            string targetPath = currentFilePath.Replace(jdfPath, string.Empty);
            targetPath = targetPath.Trim('\\');
            if (Form1.treeNodeList.Count > 0)
            {
                targetPath = "";
                foreach (var tn in Form1.treeNodeList)
                {
                    targetPath += tn.tn.Tag.ToString().Replace(jdfPath, string.Empty).Trim('\\') + ",";

                }
                targetPath = targetPath.Trim(',');
            }


            var jdfCmd = diskName + " &cd " + jdfPath + "& jdf upload " + targetPath;
            if (targetPath.Contains("html"))
            {
                jdfCmd = diskName + " &cd " + jdfPath + "& jdf upload " + targetPath + " -p ";
            }

            if (radioButtonDebug.Checked)
            {
                jdfCmd += " -debug";
            }

            Common.form1.uC_Console1.execAnsy(jdfCmd);
     
        }

 
    }
}
