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
using System.Threading;

namespace TH_3
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(Convert.ToInt32(textBox1.Text));
            while(true)
            {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] recvMsg = udpClient.Receive(ref iPEndPoint);
                string data = Encoding.UTF8.GetString(recvMsg);
                listView1.Items.Add(iPEndPoint.Address.ToString() + ":" + data);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }
    }
}
