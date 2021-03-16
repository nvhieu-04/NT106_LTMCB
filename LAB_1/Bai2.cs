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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            soThuNhat.ResetText();
            soThuHai.ResetText();
            soThuBa.ResetText();
            min.ResetText();
            max.ResetText();
        }

        private void find_Click(object sender, EventArgs e)
        {
            double a, b, c, Max, Min;
            a = Convert.ToDouble(soThuNhat.Text);
            b = Convert.ToDouble(soThuHai.Text);
            c = Convert.ToDouble(soThuBa.Text);
            Max = Math.Max(a, b);
            Max = Math.Max(Max,c);
            Min = Math.Min(a, b);
            Min = Math.Min(Min,c);

            max.Text = Max.ToString();
            min.Text = Min.ToString();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
