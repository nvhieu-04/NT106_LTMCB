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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            label9.ResetText();
            label10.ResetText();
            label11.ResetText();
            label12.ResetText();
            label13.ResetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            label9.ResetText();
            label10.ResetText();
            label11.ResetText();
            label12.ResetText();
            label13.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int a = Int32.Parse(textBox2.Text);
            int b = Int32.Parse(textBox1.Text);
            int c = 1;
            int d = 1;
            int s1 = 0;
            int s2 = 0;
            double s3 = 0;
            for(int i = 1; i <= a;i++)
            {
                c = c * i;
            }
            for (int i = 1; i <= b; i++)
            {
                d =d * i;

            }
            for (int i = 1; i <= a; i++)
            {
                s1 = s1 + i;
            }
            for (int i = 1; i <= b; i++)
            {
                s2 = s2 + i;
            }
            for (int i = 1; i <= b; i++)
            {
                s3 = s3 + Math.Pow(a,i) ;
            }
            label9.Text = Convert.ToString(c);
            label10.Text = Convert.ToString(d);
            label11.Text = Convert.ToString(s1);
            label12.Text = Convert.ToString(s2);
            label13.Text = Convert.ToString(s3);



        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
