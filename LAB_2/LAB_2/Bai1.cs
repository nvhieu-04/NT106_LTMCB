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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            fs.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt;)|*.txt;";
            save.ShowDialog();
            FileStream fs = new FileStream(save.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);
            string content = richTextBox1.Text;
            string c = content.ToUpper();
            sw.WriteLine(c);
            sw.Close();
        }
    }
}
