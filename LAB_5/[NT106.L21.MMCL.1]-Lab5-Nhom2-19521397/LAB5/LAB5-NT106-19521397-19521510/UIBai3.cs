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
using MailKit;
using System.Net.Mail;
using System.Net;


namespace LAB5_NT106_19521397_19521510
{
    public partial class UIBai3 : Form
    {
        public UIBai3()
        {
            InitializeComponent();
            ReceiveMail();
        }
        public void ReceiveMail()
        {
            using (var emailClient = new ImapClient())
            {
                try
                {
                    emailClient.Connect("127.0.0.1", 143, 0);
                    emailClient.Authenticate(Bai3.user, Bai3.password);
                    var inbox = emailClient.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    listView1.Columns.Add("Email", 200);
                    listView1.Columns.Add("From", 100);
                    listView1.Columns.Add("Thời gian", 100);
                    listView1.View = View.Details;
                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);
                        ListViewItem lvi = new ListViewItem(message.Subject);
                        lvi.SubItems.Add(message.From.ToString());
                        lvi.SubItems.Add(message.Date.Date.ToString());
                        listView1.Items.Add(lvi);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UIBai3Send bai3_send = new UIBai3Send();
            bai3_send.Show();
            this.Close();
        }
    }
}
