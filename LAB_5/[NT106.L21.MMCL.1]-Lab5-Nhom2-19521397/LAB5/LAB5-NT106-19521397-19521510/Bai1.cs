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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                string mailfrom = textBox1.Text.ToString().Trim();
                string mailto = textBox2.Text.ToString().Trim();
                string passwod = textBox3.Text.ToString().Trim();
                var basicCredential = new NetworkCredential(mailfrom, passwod);
                using(MailMessage mailMessage=new MailMessage())
                {
                    MailAddress mailAddress = new MailAddress(mailfrom);
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = basicCredential;

                    mailMessage.From = mailAddress;
                    mailMessage.Subject = textBox4.Text.ToString().Trim();
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Body = richTextBox1.Text.ToString();
                    mailMessage.To.Add(mailto);
                    
                    try
                    {
                        smtpClient.Send(mailMessage);

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }    
            }    
        }
    }
}
