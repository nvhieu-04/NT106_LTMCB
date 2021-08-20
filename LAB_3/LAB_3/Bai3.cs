using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai3_Server sv = new Bai3_Server();
            sv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai3_Client cl = new Bai3_Client();
            cl.Show();
        }
    }
}
