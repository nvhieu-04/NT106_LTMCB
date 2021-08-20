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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LAB_3
{
    public partial class Bai3_Client : Form
    {
        public Bai3_Client()
        {
            InitializeComponent();
        }
        IPEndPoint ipEndPoint;
        Socket client;
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
       
        void Connect()
        {
            ipEndPoint = new IPEndPoint(IPAddress.Parse("172.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(ipEndPoint);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối");
                return;

            }
        }
        void Close()
        {
            client.Close();

        }
        void Send()
        {
            client.Send(Serialize("Server running on 127.0.0.1:8080\n"+"Hello Server \n"));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Send();
        }
        private void Client_Closed(object sender,FormClosedEventArgs e)
        {
            Close();
        }
    }
}
