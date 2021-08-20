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
using System.Net.Sockets;
namespace LAB_3
{
    public partial class Bai1_Client : Form
    {
        public Bai1_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udp = new UdpClient();
            IPAddress ipAddress = IPAddress.Parse(this.textBox1.Text);
            udp.Connect(ipAddress, int.Parse(this.textBox2.Text));
            Byte[] sendBytes = Encoding.Unicode.GetBytes(this.textBox3.Text);
            udp.Send(sendBytes, sendBytes.Length);
            textBox3.Clear();
        }

        private void Bai1_Client_Load(object sender, EventArgs e)
        {

        }
    }
}
