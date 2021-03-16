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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int soThuNhat;
            if (int.TryParse(a.Text, out soThuNhat))
            {
               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soThuNhat = Int32.Parse(a.Text);
            int soThuHai = Int32.Parse(b.Text);
            int ketqua = soThuNhat + soThuHai;
            c.Text = ketqua.ToString();

        }

        private void b_TextChanged(object sender, EventArgs e)
        {
            int soThuHai;
            if (int.TryParse(a.Text, out soThuHai))
            {

            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }
    }
}
