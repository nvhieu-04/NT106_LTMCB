using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai_1 = new Bai1();
            bai_1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 Bai_2 = new Bai2();
            Bai_2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 Bai_3 = new Bai3();
            Bai_3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai4 Bai_4 = new Bai4();
            Bai_4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai5 Bai_5 = new Bai5();
            Bai_5.Show();
        }
    }
}
