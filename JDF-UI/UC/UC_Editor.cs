using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JDF_UI.UC
{
    public partial class UC_Editor : UserControl
    {
        public UC_Editor()
        {
            InitializeComponent();
        }

       

        public void addNewTab(string path){
            bool hasTab = false;
            FileInfo fi = new FileInfo(path);
            foreach (TabPage tp in tabControlEditor.TabPages)
            {
                if (tp.Tag.ToString()==fi.FullName)
                {
                    hasTab = true;
                }
            }

            if (!hasTab)
            {
                tabControlEditor.TabPages.Add(fi.FullName, fi.Name, 0);
                WebKit.WebKitBrowser wb = new WebKit.WebKitBrowser();
                wb.Dock = DockStyle.Fill;
                Panel p = new Panel();
                p.Controls.Add(wb);
                p.Dock=DockStyle.Fill;
                tabControlEditor.TabPages[fi.FullName].Controls.Add(p);
                tabControlEditor.TabPages[fi.FullName].Tag = fi.FullName;
                string html = Properties.Resources.editor.ToString();
                html = html.Replace("{{code}}", File.ReadAllText(path));
                wb.DocumentText = html;
                p.Select();
                p.Focus();
                
  
            }
            tabControlEditor.SelectedTab = tabControlEditor.TabPages[fi.FullName];
            //tabControlEditor.Select();
            //tabControlEditor.Focus();
        }

        public void setWbFocus() {
            if (tabControlEditor.SelectedTab!=null) {
                WebKit.WebKitBrowser browser = (WebKit.WebKitBrowser)tabControlEditor.SelectedTab.Controls[0].Controls[0];
                browser.Select();
                browser.Focus();
            }
        }

        private void tabControlEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            setWbFocus();
        }

        private void UC_Editor_Load(object sender, EventArgs e)
        {
            //tabControlEditor.TabPages.Add("______main", "京东JDC", 0);
            //WebKit.WebKitBrowser wb = new WebKit.WebKitBrowser();
            //wb.Dock = DockStyle.Fill;
            //Panel p = new Panel();
            //p.Controls.Add(wb);
            //p.Dock = DockStyle.Fill;
            //tabControlEditor.TabPages["______main"].Controls.Add(p);
            //tabControlEditor.TabPages["______main"].Tag = "______main";
            //wb.Navigate("http://fe.jd.com/");
        }
    }
}
