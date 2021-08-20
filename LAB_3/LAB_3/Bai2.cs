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

namespace LAB_3
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();

        }
        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            //Khởi tạo mảng byte nhận dữ liệu
            byte[] recv = new byte[1];
            //tạo socket bên gửi
            Socket clientSocket;
            //Tạo socket bên nhận , socket này là socket lắng nghe các kết nối tới nó tại địa chỉ IP của và port 8080.Đây là 1 TCP/IP socket.
            //
            //
            //
            //
            Socket listenerSocket = new Socket
            (
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
            );
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            //
            listenerSocket.Bind(ipepServer);
            //bắt đầu lắng nghe 
            //với backlog
            listenerSocket.Listen(-1);
            //Đồng ý kết nối
             clientSocket = listenerSocket.Accept();
            //Nhận dữ liệu
            listView1.Items.Add(new ListViewItem("New client connected"));
            while(clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceived = clientSocket.Receive(recv);
                    text += Encoding.UTF8.GetString(recv);

                }
                while (text[text.Length - 1] != '\n');
                listView1.Items.Add(new ListViewItem(text));
               
            }
            listenerSocket.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
