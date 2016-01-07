using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices; 

namespace JDF_UI.UC
{
    public partial class UC_FolderTree : UserControl
    {
        public static string folderTitle = "";
        public TreeNode PreSelectedNode=null;
        public static List<string>openedFolder =new List<string>();
        TreeNode _currentTreeNode = null;

        public UC_FolderTree()
        {
            InitializeComponent();
        }



        public void initwithRoot(string rootStr) {
            clearTree();

            treeViewDirectory.BeginUpdate();
            treeViewDirectory.ImageList = imageList1;
            treeViewDirectory.SelectedImageIndex = 0;
            treeViewDirectory.ImageIndex = 0;
            ShowRoot(rootStr);
            treeViewDirectory.EndUpdate();
        
        }


        public void initwithRoot()
        {
            clearTree();

            treeViewDirectory.BeginUpdate();
            treeViewDirectory.ImageList = imageList1;
            treeViewDirectory.SelectedImageIndex = 0;
            treeViewDirectory.ImageIndex = 0;
            EnumDrivers();
            treeViewDirectory.EndUpdate();

        }



        private void ShowRoot(string dir) {
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "项目";
            rootNode.ImageIndex = 0;
            rootNode.Expand();
            treeViewDirectory.Nodes.Add(rootNode);
            treeViewDirectory.SelectedNode = rootNode.FirstNode;

            DirectoryInfo di = new DirectoryInfo(dir);
            TreeNode tn = new TreeNode(di.Name);
            tn.Tag = dir;
            treeViewDirectory.Nodes[0].Nodes.Add(tn);
        }

        private void EnumDrivers()
        {

            TreeNode rootNode = new TreeNode();
            rootNode.Text = "我的电脑";
            rootNode.ImageIndex = 0;

            rootNode.Expand();
            treeViewDirectory.Nodes.Add(rootNode);
            treeViewDirectory.SelectedNode = rootNode.FirstNode;

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            int j = 0;
            try
            {
                int i = 0;
                foreach (DriveInfo d in allDrives)
                {
                    if (d.DriveType.ToString() == "Fixed")
                    {
                        TreeNode tn = new TreeNode(d.Name);



                        tn.ImageIndex = 1;
                        tn.SelectedImageIndex = 3;
                        i++;
                        tn.Tag = d.RootDirectory.FullName;
                        treeViewDirectory.Nodes[0].Nodes.Add(tn);

                        treeViewDirectory.Nodes[0].Nodes[j].Text = d.Name + "(本地硬盘," + d.TotalFreeSpace / 1024 / 1024 / 1024 + "G/" + d.TotalSize / 1024 / 1024 / 1024 + "G)";


                        ShowDirs(tn);
                        j++;
                    }
                }
            }
            catch (System.Exception)
            {
            }
        }

        private void ShowDirs(TreeNode tn)
        {
            tn.Nodes.Clear();
            try
            {
                DirectoryInfo DirInfo = new DirectoryInfo(tn.Tag.ToString());
 
                if (!DirInfo.Exists)
                {
                    return;
                }
                else
                {
                    DirectoryInfo[] Dirs;
                    FileInfo[] Fis;
                    try
                    {
                        Dirs = DirInfo.GetDirectories();
                        Fis = DirInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                    }
                    catch (Exception e)
                    {
                        return;
                    }
                    foreach (DirectoryInfo Dir in Dirs)
                    {
                        TreeNode folderTn = new TreeNode(Dir.Name);
                        folderTn.SelectedImageIndex = 3;
                        folderTn.ImageIndex = 1;
                        folderTn.Tag = Dir.FullName;
                        tn.Nodes.Add(folderTn);
                    }

                    foreach (FileInfo fi in Fis)
                    {
                        TreeNode fileTn = new TreeNode(fi.Name);
                        fileTn.SelectedImageIndex = 3;
                        fileTn.ImageIndex = 2;
                        fileTn.Tag = fi.FullName;
                        tn.Nodes.Add(fileTn);
                    }



                }
            }
            catch (System.Exception)
            { }
        }

        private void treeViewDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
           
        }

 

        private void treeViewDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
            

        }

  

        private void treeViewDirectory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
        }

     

        private void treeViewDirectory_AfterExpand(object sender, TreeViewEventArgs e)
        {

            

            treeViewDirectory.BeginUpdate();
            foreach (TreeNode tn in e.Node.Nodes)
            {
                ShowDirs(tn);
 
            }
            treeViewDirectory.EndUpdate();

            if (e.Node.Tag != null)
            {
                if (!openedFolder.Contains(e.Node.Tag.ToString()))
                {
                    openedFolder.Add(e.Node.Tag.ToString());
                }
            }
        }




        public void clearTree() {
            treeViewDirectory.Nodes.Clear();
        }



        List<string> getAddFolder(string path)
        {
            List<string> result = new List<string>();
            var treeNode = getTreeNodeByPath(path);
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists) { return result; }
            foreach (DirectoryInfo di in dirInfo.GetDirectories("*",SearchOption.TopDirectoryOnly))
            {
                bool flag = false;
                foreach (TreeNode tn in treeNode.Nodes)
                {
                    if (tn.Tag.ToString() == di.FullName && tn.ImageIndex==1)
                    {
                        flag = true;
                    }
                
                }
                if (!flag)
                {
                    result.Add(di.FullName);
                }
            
            }
            return result;
        }

        List<string> getAddFile(string path)
        {
            List<string> result = new List<string>();
            var treeNode = getTreeNodeByPath(path);
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            foreach (FileInfo fi in dirInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly))
            {
                bool flag = false;
                foreach (TreeNode tn in treeNode.Nodes)
                {
                    if (tn.Tag.ToString() == fi.FullName && tn.ImageIndex == 2)
                    {
                        flag = true;
                    }

                }
                if (!flag)
                {
                    result.Add(fi.FullName);
                }

            }
            return result;
        }

        List<string> getRemoveFolder(string path)
        {

            List<string> result = new List<string>();
            var treeNode = getTreeNodeByPath(path);
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
            {
                return result;
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.ImageIndex == 2)
                {
                    continue;
                }

                bool flag = false;
                foreach (DirectoryInfo di in dirInfo.GetDirectories("*", SearchOption.TopDirectoryOnly))
                {
                    if (tn.Tag.ToString() == di.FullName  )
                    {
                        flag = true;
                    }

                  
                }

                if (!flag)
                {
                    result.Add(tn.Tag.ToString());
                }
               

            }


           
            return result;
        
        
        
        }


        List<string> getRemoveFile(string path)
        {
            List<string> result = new List<string>();
            var treeNode = getTreeNodeByPath(path);
            DirectoryInfo dirInfo = new DirectoryInfo(path);


            foreach (TreeNode tn in treeNode.Nodes)
            {
                if (tn.ImageIndex == 1)
                {
                    continue;
                }

                bool flag = false;
               
                foreach (FileInfo fi in dirInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly))
                {
                    if (tn.Tag.ToString() == fi.FullName)
                    {
                        flag = true;
                    }
                   
                }

                if (!flag)
                {
                    result.Add(tn.Tag.ToString());
                }

            }


           
            return result;
        }




        TreeNode getTreeNodeByPath(string path)
        {
            _currentTreeNode=null;
 
            _getTreeNodeByPath(treeViewDirectory.Nodes[0], path);
 
            
            return _currentTreeNode;
        
        }

        void _getTreeNodeByPath(TreeNode tn, string path)
        {
          
            foreach (TreeNode n in tn.Nodes)
            {
                if (n.Tag.ToString().Contains("新建文件夹")) {
                   
                }
                if (n.Tag.ToString() == path)
                {
 
                    _currentTreeNode = n;
                    return;
                }
                else {
                    _getTreeNodeByPath(n, path);
                
                }
            }
        
        }


        public void reflashAllList() {
            foreach (string s in openedFolder) {
                reflashTreeList(s);
            
            }
        }


        public void reflashTreeList(string path)
        {
            
            treeViewDirectory.BeginUpdate();
            var treeNode = getTreeNodeByPath(path);

            var addFolderList = getAddFolder(path);
            foreach (string s in addFolderList) {
                DirectoryInfo di = new DirectoryInfo(s);
                TreeNode folderTn = new TreeNode(di.Name);
                folderTn.SelectedImageIndex = 3;
                folderTn.ImageIndex = 1;
                folderTn.Tag = di.FullName;

                var dis = di.Parent.GetDirectories("*",SearchOption.TopDirectoryOnly);
                int index = 0;
                for (int i = 0; i < dis.Length;i++ ) {
                    if (dis[i].FullName==s)
                    {
                        index = i;
                    }
                
                }




                var dis1 = di.GetDirectories("*", SearchOption.TopDirectoryOnly);
                if (dis1.Length > 0)
                {
                    foreach (DirectoryInfo _di in dis1)
                    {
                        TreeNode folderTn1 = new TreeNode(_di.Name);
                        folderTn1.SelectedImageIndex = 3;
                        folderTn1.ImageIndex = 1;
                        folderTn1.Tag = _di.FullName;
                        folderTn.Nodes.Add(folderTn1);
                    }

                }



                var dis2 = di.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                if (dis2.Length > 0)
                {
                    foreach (FileInfo __di in dis2)
                    {
                        TreeNode folderTn1 = new TreeNode(__di.Name);
                        folderTn1.SelectedImageIndex = 3;
                        folderTn1.ImageIndex =2;
                        folderTn1.Tag = __di.FullName;
                        folderTn.Nodes.Add(folderTn1);
                    }

                }








                treeNode.Nodes.Insert(index, folderTn);
            }








            var removeFolderList = getRemoveFolder(path);
            foreach (string s in removeFolderList)
            {
                var tn = getTreeNodeByPath(s);
                tn.Remove();
            }


            var removeFileList = getRemoveFile(path);
            foreach (string s in removeFileList)
            {
                var tn = getTreeNodeByPath(s);
                tn.Remove();
            }



            var addFileList = getAddFile(path);
            foreach (string s in addFileList)
            {
                FileInfo fi = new FileInfo(s);
                TreeNode fileTn = new TreeNode(fi.Name);
                fileTn.SelectedImageIndex = 3;
                fileTn.ImageIndex = 2;
                fileTn.Tag = fi.FullName;

                var fis = fi.Directory.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                int index = 0;
                for (int i = 0; i < fis.Length; i++)
                {
                    if (fis[i].FullName == s)
                    {
                        index = i;
                    }

                }
                index += fi.Directory.GetDirectories("*",SearchOption.TopDirectoryOnly).Length;
                treeNode.Nodes.Insert(index, fileTn);
            }




            //DirectoryInfo DirInfo = new DirectoryInfo(path);
            //DirectoryInfo[] Dirs;
            //FileInfo[] Fis;
            //try
            //{
            //    Dirs = DirInfo.GetDirectories();
            //    Fis = DirInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
            //}
            //catch (Exception e)
            //{
            //    return;
            //}
            //foreach (DirectoryInfo Dir in Dirs)
            //{

            //    foreach (TreeNode n in node.Nodes)
            //    {
                    
                
            //    }
            //    TreeNode folderTn = new TreeNode(Dir.Name);
            //    folderTn.SelectedImageIndex = 3;
            //    folderTn.ImageIndex = 1;
            //    folderTn.Tag = Dir.FullName;
               
            //}

            //foreach (FileInfo fi in Fis)
            //{
            //    TreeNode fileTn = new TreeNode(fi.Name);
            //    fileTn.SelectedImageIndex = 3;
            //    fileTn.ImageIndex = 2;
            //    fileTn.Tag = fi.FullName;
             
            //}
            

            //foreach (TreeNode tn in node.Nodes)
            //{
            //    ShowDirs(tn);

            //}
            treeViewDirectory.EndUpdate();
        
        
        }


        public class NodeSorter : IComparer
        {
            // Compare the length of the strings, or the strings 
            // themselves, if they are the same length. 
            public int Compare(object x, object y)
            {
                TreeNode tx = x as TreeNode;
                TreeNode ty = y as TreeNode;

                // Compare the length of the strings, returning the difference. 
                if (tx.Text.Length != ty.Text.Length)
                    return tx.Text.Length - ty.Text.Length;

                // If they are the same length, call Compare. 
                return string.Compare(tx.Text, ty.Text);
            }
        }

        private void imageButton1_Click(object sender, EventArgs e)
        {
            Common.form1.uC_FolderTree1.reflashAllList();
        }

 
    }
}
