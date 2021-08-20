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
using System.Threading;

namespace TH_3
{
    public partial class TCPClient : Form
    {
        public TCPClient()
        {
            InitializeComponent();
        }
        private TcpClient tCPClient = new TcpClient();
        NetworkStream ns;
        private void Send()
        {
            ns = tCPClient.GetStream();
            Byte[] data = Encoding.ASCII.GetBytes("Hello server \n");
            ns.Write(data, 0, data.Length);
        }

        private NetworkStream GetStream()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 8080);
            if(!tCPClient.Connected)
            {
                tCPClient.Connect(iPEndPoint);
                Send();
            } 
            else
            {
                Thread send = new Thread(Send);
                send.Start();
            }    

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte[] bytes = Encoding.ASCII.GetBytes("Quit\n");
            ns.Write(bytes, 0, bytes.Length);
            ns.Close();
            tCPClient.Close();
            button1.Enabled = false;
            button2.Enabled = false;
        }

    }
}
