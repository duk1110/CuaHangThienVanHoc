namespace WinFormsApp12
{
    partial class HoaDon
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
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
            label7 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 43);
            label1.TabIndex = 0;
            label1.Text = "Phiếu Hóa Đơn";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(26, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(917, 254);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã SP";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 170;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên sản phẩm";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.HeaderText = "Số lượng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 170;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá bán";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 170;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thành tiền";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 170;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 112);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã ĐH:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 158);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 3;
            label3.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 211);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 268);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 5;
            label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 112);
            label6.Name = "label6";
            label6.Size = new Size(175, 25);
            label6.TabIndex = 6;
            label6.Text = "Nhân viên phụ trách:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(212, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(212, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(212, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(212, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(734, 109);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(577, 628);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 12;
            label7.Text = "Tổng tiền:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(674, 625);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(210, 31);
            textBox6.TabIndex = 13;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 720);
            Controls.Add(textBox6);
            Controls.Add(label7);
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
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "HoaDon";
            Text = "HoaDon";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
    }
}