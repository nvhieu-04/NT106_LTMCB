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
using System.IO;



namespace LAB_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All File|*.*";
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    string filename = Path.GetFileName(ofd.FileName);
                    string path = Path.GetFullPath(ofd.FileName);
                    // Get the object used to communicate with the server.
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(hostIP.Text + "/" + filename);
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    // This example assumes the FTP site uses anonymous logon.
                    request.Credentials = new NetworkCredential(user.Text, pass.Text);

                    Stream ftpStream = request.GetRequestStream();
                    FileStream file = File.OpenRead(path);

                    //Setup variables we'll use to read the file.
                    int length = 1024;
                    byte[] buffer = new byte[length];
                    int bytesRead = 0;

                    //Write the file to the request stream.
                    do
                    {
                        bytesRead = file.Read(buffer, 0, length);
                        ftpStream.Write(buffer, 0, bytesRead);
                    }
                    while (bytesRead != 0);

                    //Close the streams.
                    file.Close();
                    ftpStream.Close();

                    MessageBox.Show("Upload thành công");
                    string[] filenames = GetFileList();
                    listView1.Items.Clear();
                    foreach (string filename1 in filenames)
                    {
                        listView1.Items.Add(filename1);
                    }
                    string selectedItem = listView1.SelectedItems[0].Text;
                }
                
            }
        }
        private void Download(string filePath, string fileName)
        {
            FtpWebRequest request;
            try
            {
                FileStream outputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create);
                request = (FtpWebRequest)FtpWebRequest.Create(new Uri(hostIP.Text + "/" + fileName));
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.UseBinary = true;
                request.Credentials = new NetworkCredential(user.Text, pass.Text);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string[] GetFileList()
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest request;
            try
            {
                request = (FtpWebRequest)FtpWebRequest.Create(new Uri(hostIP.Text));
                request.UseBinary = true;
                request.Credentials = new NetworkCredential(user.Text, pass.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                downloadFiles = null;
                return downloadFiles;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = listView1.SelectedItems[0].Text;
            MessageBox.Show("Bạn sẽ tải file " + selectedItem);
            FolderBrowserDialog fldDlg = new FolderBrowserDialog();
            if (selectedItem.Trim().Length > 0)
            {
                if (fldDlg.ShowDialog() == DialogResult.OK)
                {
                    Download(fldDlg.SelectedPath, selectedItem.Trim());
                }
                MessageBox.Show("Tải xuống "+ selectedItem + " thành công");
            }
            else
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] filenames = GetFileList();
            listView1.Items.Clear();
            foreach (string filename1 in filenames)
            {
                listView1.Items.Add(filename1);
            }
        }
    }
}
