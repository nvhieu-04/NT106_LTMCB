using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace LAB_2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            DirectoryInfo di = new DirectoryInfo("C:\\test");
            FileInfo[] fiArr = di.GetFiles();
            foreach (var fileinfo in fiArr)
            {
                string[] cont = new string[4];
                ListViewItem lvi;
                cont[0] = fileinfo.Name;
                cont[1] = fileinfo.Length.ToString();
                cont[2] = fileinfo.Extension;
                cont[3] = fileinfo.CreationTime.ToString();
                lvi = new ListViewItem(cont);
                listView1.Items.Add(lvi);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

       
        }
}
