using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_NT106_19521397_19521510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }
    }
}
