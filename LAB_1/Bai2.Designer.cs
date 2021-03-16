
namespace LAB_1
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.find = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.soThuNhat = new System.Windows.Forms.TextBox();
            this.soThuHai = new System.Windows.Forms.TextBox();
            this.soThuBa = new System.Windows.Forms.TextBox();
            this.max = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(132, 240);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(133, 69);
            this.find.TabIndex = 0;
            this.find.Text = "Tìm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(337, 240);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(133, 69);
            this.delete.TabIndex = 1;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(541, 240);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(133, 69);
            this.exit.TabIndex = 2;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // soThuNhat
            // 
            this.soThuNhat.Location = new System.Drawing.Point(132, 112);
            this.soThuNhat.Multiline = true;
            this.soThuNhat.Name = "soThuNhat";
            this.soThuNhat.Size = new System.Drawing.Size(133, 43);
            this.soThuNhat.TabIndex = 3;
            // 
            // soThuHai
            // 
            this.soThuHai.Location = new System.Drawing.Point(337, 108);
            this.soThuHai.Multiline = true;
            this.soThuHai.Name = "soThuHai";
            this.soThuHai.Size = new System.Drawing.Size(133, 45);
            this.soThuHai.TabIndex = 4;
            this.soThuHai.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // soThuBa
            // 
            this.soThuBa.Location = new System.Drawing.Point(541, 108);
            this.soThuBa.Multiline = true;
            this.soThuBa.Name = "soThuBa";
            this.soThuBa.Size = new System.Drawing.Size(133, 43);
            this.soThuBa.TabIndex = 5;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(186, 373);
            this.max.Multiline = true;
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Size = new System.Drawing.Size(134, 46);
            this.max.TabIndex = 6;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(506, 369);
            this.min.Multiline = true;
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Size = new System.Drawing.Size(134, 46);
            this.min.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "SỐ LỚN NHẤT SỐ NHỎ NHẤT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "C";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số lớn nhất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số nhỏ nhất";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.max);
            this.Controls.Add(this.soThuBa);
            this.Controls.Add(this.soThuHai);
            this.Controls.Add(this.soThuNhat);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.find);
            this.Name = "Bai2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox soThuNhat;
        private System.Windows.Forms.TextBox soThuHai;
        private System.Windows.Forms.TextBox soThuBa;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}