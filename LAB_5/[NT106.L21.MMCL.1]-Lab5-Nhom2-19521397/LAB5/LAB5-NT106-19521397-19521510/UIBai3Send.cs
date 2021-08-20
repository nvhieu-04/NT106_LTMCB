using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LAB5_NT106_19521397_19521510
{
    public partial class UIBai3Send : Form
    {
        public UIBai3Send()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtp = new SmtpClient("127.0.0.1"))
            {
                string mailFrom = Bai3.user;
                string mailTo = textBox1.Text.Trim();
                string password = Bai3.password;
                var basicCredential = new NetworkCredential(mailFrom, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(mailFrom);
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = basicCredential;
                    message.From = fromAddress;
                    message.Subject = textBox2.Text.Trim();
                    message.IsBodyHtml = true;
                    message.Body = richTextBox1.Text;
                    message.To.Add(mailTo);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Send successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
