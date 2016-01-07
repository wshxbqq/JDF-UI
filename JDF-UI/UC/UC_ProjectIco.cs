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
    public partial class UC_ProjectIco : UserControl
    {
        private string  _ProjectPath;
        public string ProjectPath
        {
            get { return _ProjectPath; }
            set { _ProjectPath = value; }
        }
        public bool isSelected=false;
        public UC_ProjectIco()
        {
            InitializeComponent();
        }

        public void initWithPath(string path){
            DirectoryInfo di = new DirectoryInfo(path);
            label_name.Text = di.Name;
            ProjectPath = path;
        
        }

        public void selected() {
            isSelected = true;
            this.BackColor = Color.GreenYellow;

        }

        public void unselected()
        {
            isSelected = false; ;
            this.BackColor = Color.Gray; ;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void label_name_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

    }
}
