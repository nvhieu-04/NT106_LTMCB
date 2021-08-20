
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;

namespace LAB5_NT106_19521397_19521510
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var emailClient = new ImapClient())
            {
                try
                {
                    emailClient.Connect("127.0.0.1", 143, 0);
                    emailClient.Authenticate(textBox1.Text, textBox2.Text);
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
                    label5.Text = inbox.Count.ToString();
                    label6.Text = inbox.Recent.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

}
