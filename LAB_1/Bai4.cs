using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            label4.ResetText();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double val;
            double a = Convert.ToDouble(textBox1.Text);
            string var;
            var = comboBox1.Text;
            if (var == "USD")
            {
                val = (a * 22.772 );
                textBox2.Text = Convert.ToString(val);
                label4.Text = "1 USD = 22.772";
            }
            if (var == "EUR")
            {
                val = (a * 28.132);
                textBox2.Text = Convert.ToString(val);
                label4.Text = "1 EUR = 28.132";
            }
            if (var == "GBP")
            {
                val = (a * 31.538);
                textBox2.Text = Convert.ToString(val);
                label4.Text = "1 GBP = 31.538";
            }
            if (var == "SGD")
            {
                val = (a * 17.286);
                textBox2.Text = Convert.ToString(val);
                label4.Text = "1 SGD = 17.286";
            }
            if (var == "JPY")
            {
                val = (a * 0.214);
                textBox2.Text = Convert.ToString(val);
                label4.Text = "1 JPY = 0.214";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}