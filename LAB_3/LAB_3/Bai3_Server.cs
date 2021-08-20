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
    public partial class Bai3_Server : Form
    {
        public Bai3_Server()
        {
            InitializeComponent();
        }
        IPEndPoint ipEndPoint;
        Socket server;
        List<Socket> list;
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }
        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while(true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    AddText(message);
                }
            }
            catch
            {
                list.Remove(client);
                client.Close();
            }
        }
        void Close()
        {
            server.Close();
        }
        void AddText(string tx)
        {
            if(richTextBox1.InvokeRequired)
            {
                add t = new add(AddText);
                this.Invoke(t, new object[] { tx });
                return;
            }
            richTextBox1.Text += tx;
        }
        delegate void add(string t);
        void Connect()
        {
            list = new List<Socket>();
            ipEndPoint = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ipEndPoint);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while(true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        list.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);

                        
                    }
                }
                catch
                {
                    ipEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            }
                );
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddText(richTextBox1.Text);
        }
    }
}
