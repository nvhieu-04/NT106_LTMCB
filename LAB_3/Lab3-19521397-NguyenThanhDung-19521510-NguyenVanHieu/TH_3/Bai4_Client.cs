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
namespace TH_3
{
    public partial class Bai4_Client : Form
    {
        public Bai4_Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            start();
        }
        private Socket _client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public object _currentData;
        public const int _buffer = 1024;
        int port;
        IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
        IPEndPoint iPEndPoint;
        private void start()
        {
            port = 8080;
            iPEndPoint = new IPEndPoint(iPAddress, port);
            while (true) {
                try
                {
                    _client.Connect(iPEndPoint);
                    Thread listen = new Thread(Receive);
                    listen.IsBackground = true;
                    listen.Start();
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    port++;
                }
            }
            
        }
        private void Send(string data_need_to_send)
        {
            try
            {
                _client.Send(Serialize(data_need_to_send));

            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void Receive()
        {
            _currentData = new object();
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[_buffer * 5];
                    _client.Receive(buffer);
                    _currentData = Deserialize(buffer);
                    string data = _currentData as string;

                    listView1.Items.Add(data);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string text = textBox2.Text+": " + textBox1.Text;
            
            string text_sended = _client.LocalEndPoint.ToString() + "|" + text;

            Send(text_sended);
        }

        byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(ms);
        }
    }
}
