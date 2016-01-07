using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace JDF_UI
{
    public partial class Form2 : Form
    {

        string START_PATH = System.Windows.Forms.Application.StartupPath;

        public Form2()
        {
            InitializeComponent();
        }

        int selectedIdx = 0;
        List<JDF_UI.UC.UC_ProjectIco> uc_p_list = new List<UC.UC_ProjectIco>();

        
        private void Form2_Load(object sender, EventArgs e)
        {
            resizeIco();
        }


        void aa_Click(object sender, EventArgs e)
        {
            JDF_UI.UC.UC_ProjectIco pico = (JDF_UI.UC.UC_ProjectIco)sender;
            selectedIdx = uc_p_list.IndexOf(pico);
            uC_FolderTree1.initwithRoot(pico.ProjectPath);
            resizeIco();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {

            //folderBrowserDialog1.ShowDialog();
            //string jdfProject = folderBrowserDialog1.SelectedPath;
            //var fileStr = File.ReadAllText(START_PATH + "\\userdata.txt");
            //var projects_list =new List<string>();
            //projects_list.AddRange(fileStr.Split('?'));

            //if (jdfProject != "" && !projects_list.Contains(jdfProject))
            //{
            //    fileStr = fileStr + "?" + jdfProject;
            //    File.WriteAllText(START_PATH + "\\userdata.txt", fileStr.Trim('?'));
            //}
            

            SimpleHTTPServer myServer = new SimpleHTTPServer(@"D:\jdProject");
           
        }


        void resizeIco()
        {
            foreach(JDF_UI.UC.UC_ProjectIco pico in uc_p_list){
                pico.Parent.Controls.Remove(pico);
            }

            uc_p_list.Clear();
            var projects = File.ReadAllText(START_PATH + "\\userdata.txt").Split('?');
            if (projects.Length<=0)
            {
                btn_add.Location = new Point(10, 10);
                return;
            }
            int idx = 0;
            int current_y = 10;
            foreach (string p in projects)
            {
                var uc_p = new JDF_UI.UC.UC_ProjectIco();
                uc_p.initWithPath(p);
                uc_p.Click += aa_Click;
                panel1.Controls.Add(uc_p);
                if (idx == selectedIdx)
                {
                    uc_p.selected();
                    uc_p.Location = new Point(4, current_y);
                    uC_FolderTree1.Location = new Point(4, current_y + uc_p.Height);
                    current_y += uC_FolderTree1.Height + uc_p.Height;
                }
                else {
                    
                    uc_p.Location = new Point(4, current_y);
                    current_y = current_y + uc_p.Height + 10;
                }
                
                
                idx++;
                uc_p_list.Add(uc_p);
   
                
            }

            btn_add.Location = new Point(25, current_y);


        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.Hide();
                Form1 f1 = new Form1();
                f1.WindowState = FormWindowState.Normal;
                f1.Show();
                f1.Activate();
            }

            if (this.WindowState == FormWindowState.Minimized)  //判断是否最小化
            {
                this.ShowInTaskbar = false;  //不显示在系统任务栏
                notifyIcon1.Visible = true;  //托盘图标可见
 
            }


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Activate();

        }

    



          


 
    }
}
