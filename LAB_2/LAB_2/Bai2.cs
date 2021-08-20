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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            textBox1.Text = open.SafeFileName.ToString();
            textBox2.Text = fs.Name.ToString();
            //So ki tu
            int charCount = content.Length;
            textBox5.Text = charCount.ToString();
            //So tu
            string[] src = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int wordcount = src.Count();
            textBox4.Text = wordcount.ToString();
            //So dong
            content = content.Replace("\r\n", "\r");
            int lineCount = richTextBox1.Lines.Count();
            textBox3.Text = lineCount.ToString();
            content = content.Replace('\r', ' ');
           

           
        }
    }
}
