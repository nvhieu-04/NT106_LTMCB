using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace TH_3
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udp = new UdpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
            byte[] msg = Encoding.UTF8.GetBytes(textBox3.Text);
            udp.Send(msg, msg.Length, iPEndPoint);
            textBox3.Clear();
        }
    }
}
