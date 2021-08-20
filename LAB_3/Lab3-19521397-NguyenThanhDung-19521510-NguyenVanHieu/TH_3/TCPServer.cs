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
    public partial class TCPServer : Form
    {
        public TCPServer()
        {
            InitializeComponent();
        }


        void StartUnsafeThread()
        {
            TcpListener server = null;
            try
            {
                IPAddress ip = IPAddress.Parse("127.0.0.1");
                IPEndPoint iPEndPoint = new IPEndPoint(ip, 8080);
                server = new TcpListener(iPEndPoint);
                server.Start();
                Byte[] bytes = new Byte[226];
                string data = null;
                while(true)
                {
                    TcpClient client;
                    client = server.AcceptTcpClient();
                    IPEndPoint iPEnd = client.Client.RemoteEndPoint as IPEndPoint;
                    IPAddress iPAddress = iPEnd.Address;
                    listView1.Items.Add("New client connect " + iPEnd);
                    NetworkStream stream = client.GetStream();
                    int i;
                    while( (i= stream.Read(bytes,0,bytes.Length))!=0)
                    {
                        data = Encoding.UTF8.GetString(bytes);
                        listView1.Items.Add(data);

                    }
                    stream.Close();
                    client.Close();
                }    

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                server.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            button1.Enabled = false;
            listView1.Items.Add("Server is running...");
        }
    }
}
