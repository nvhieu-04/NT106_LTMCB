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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai4_Server server = new Bai4_Server();
            server.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai4_Client client = new Bai4_Client();
            client.Show();
        }
    }
}
