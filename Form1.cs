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
namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text Files(*.txt;)|*.txt;";
            if (open.ShowDialog() == DialogResult.OK )
            {
               using (StreamReader sr = new StreamReader(open.FileName))
                {
                    richTextBox1.Text = await sr.ReadToEndAsync();

                }

            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt;)|*.txt;";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    await sw.WriteLineAsync(richTextBox1.Text);
                    MessageBox.Show("Save","WARNING", MessageBoxButtons.OK);
                }
            }
        }

        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Files(*.txt;)|*.txt;";
            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    await sw.WriteLineAsync(richTextBox1.Text);
                    MessageBox.Show("Save", "WARNING", MessageBoxButtons.OK);
                }
            }
        }
    }
}
