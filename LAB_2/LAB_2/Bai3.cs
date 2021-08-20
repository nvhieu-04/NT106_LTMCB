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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

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
            String content = richTextBox1.Text;
            content = content.Replace('\r', ' ');
            String[] numb = content.Split(new char[] { '+', '-', '*', '/', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            float numb1 = float.Parse(numb[0]);
            float numb2 = float.Parse(numb[1]);
            float numb3 = float.Parse(numb[2]);
            float numb4 = float.Parse(numb[3]);
            float numb5 = float.Parse(numb[4]);
            float numb6 = float.Parse(numb[5]);
            float numb7 = float.Parse(numb[6]);
            float numb8 = float.Parse(numb[7]);
            float add = numb1 + numb2;
            float sub = numb3 - numb4;
            float mult = numb5 * numb6;
            float div = numb7 / numb8;
            content = content.Replace("\r\n", "\r");
            String[] line = content.Split('\n');
            line[0] = line[0] + " = " + add;
            line[1] = line[1] + " = " + sub;
            line[2] = line[2] + " = " + mult;
            line[3] = line[3] + " = " + div;
            String content2 = line[0] + "\n" + line[1] + "\n" + line[2] + "\n" + line[3];
            richTextBox2.Text = content2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt;)|*.txt;";
            save.ShowDialog();
            FileStream fs = new FileStream(save.FileName, FileMode.CreateNew);
            StreamWriter sw = new StreamWriter(fs);
            string content = richTextBox2.Text;
            string c = content.ToUpper();
            sw.WriteLine(c);
            sw.Close();
        }
    }
}
