using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;

namespace LAB5_NT106_19521397_19521510
{
    public partial class Bai3 : Form
    {
        public static string user = "";
        public static string password = "";
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text.Trim();
            password = textBox2.Text.Trim();
            var emailClient = new ImapClient();
            try
            {
                emailClient.Connect("127.0.0.1", 143, 0);
                emailClient.Authenticate(Bai3.user, Bai3.password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            UIBai3 UI = new UIBai3();
            UI.Show();
            this.Close();
        }
    }
}
