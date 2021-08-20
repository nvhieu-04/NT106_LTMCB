using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TCPServer server = new TCPServer();
            server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TCPClient client = new TCPClient();
            client.Show();
        }
    }
}
