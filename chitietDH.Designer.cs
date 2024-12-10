namespace WinFormsApp12
{
    partial class chitietDH
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(730, 294);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(288, 34);
            label1.TabIndex = 1;
            label1.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 85);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã ĐH:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 147);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 206);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 259);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 5;
            label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 85);
            label6.Name = "label6";
            label6.Size = new Size(175, 25);
            label6.TabIndex = 6;
            label6.Text = "Nhân viên phụ trách:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(201, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(201, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(201, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(201, 256);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(593, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 11;
            // 
            // chitietDH
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 667);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "chitietDH";
            Text = "chitietDH";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}