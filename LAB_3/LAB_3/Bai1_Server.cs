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
    public partial class Bai1_Server : Form
    {
        public Bai1_Server()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private Thread ServerThread;
        private UdpClient Udp;

        private void Bai1_Server_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void StartUnsafeThread()
        {
            this.Udp = new UdpClient(int.Parse(this.textBox1.Text));
            while(true)
            {
                IPEndPoint rIpEnPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] recieveBytes = Udp.Receive(ref rIpEnPoint);
                string message = Encoding.UTF8.GetString(recieveBytes);
                this.listView1.Items.Add(new ListViewItem(rIpEnPoint.Address.ToString() + ": " +  message ));
              
            }
        }
        void TryCancelThread()
        {
            if(ServerThread != null)
            {
                this.ServerThread.Abort();
            }    
        }
        private void FormClosingEvent (object sender, FormClosedEventArgs e)
        {
            this.Udp.Close();
            this.TryCancelThread();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.button1.Visible = false;
                this.listView1.Items.Add(new ListViewItem("Listening"));
                this.TryCancelThread();
                this.ServerThread = new Thread(new ThreadStart(this.StartUnsafeThread));
                this.ServerThread.Start();

            }
            catch
            {
                this.button1.Visible = true;
            }
        }

    }
}
