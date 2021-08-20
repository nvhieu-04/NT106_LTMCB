using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace LAB_2
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        [Serializable]
        public class HocVien
        {
            public string MSSV;
            public string Hoten;
            public int SDT;
            public double DiemToan;
            public double DiemVan;
            public double DTB;

            public HocVien()
            {
                MSSV = "";
                Hoten = "";
                SDT = 0;
                DiemToan = 0.0;
                DiemVan = 0.0;
                DTB = 0.0;
            }
        }
      

        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                float n = float.Parse(textBox4.Text);
                if (!(0 <= n && n <= 10))
                {
                    textBox4.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
            try
            {
                float m = float.Parse(textBox5.Text);
                if (!(0 <= m && m <= 10))
                {
                    textBox5.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
            HocVien hv = new HocVien();
            hv.MSSV = textBox1.Text;
            hv.Hoten = textBox2.Text;
            hv.SDT = int.Parse(textBox3.Text);
            hv.DiemToan = float.Parse(textBox4.Text.Trim());
            hv.DiemVan = float.Parse(textBox5.Text);
            float dtb = float.Parse(textBox4.Text) + float.Parse(textBox5.Text) / 2;
            hv.DTB = dtb;
            try
            {
                FileStream fs = new FileStream("D:\\test.txt", FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, hv);
                fs.Close();

                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
                textBox4.ResetText();
                textBox5.ResetText();

                MessageBox.Show("Thành công");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\test.txt", FileMode.Open);
            BinaryFormatter bF = new BinaryFormatter();
            HocVien hv = new HocVien();
            while (fs.Position < fs.Length)
            {
                hv = (HocVien)bF.Deserialize(fs);
                richTextBox1.Text += hv.MSSV + "\n" + hv.Hoten +"\n" + hv.SDT + "\n" + hv.DiemToan + "\n" + hv.DiemVan + "\n" + hv.DTB + "\n\n";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int b;
            if (int.TryParse(textBox3.Text, out b))
            {
                
            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
