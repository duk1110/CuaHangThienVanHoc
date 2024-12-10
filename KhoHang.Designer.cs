namespace WinFormsApp12
{
    partial class KhoHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button4 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1339, 585);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm trong kho";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(33, 11, 97);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(999, 40);
            button4.Name = "button4";
            button4.Size = new Size(132, 44);
            button4.TabIndex = 2;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(247, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(746, 36);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1327, 489);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(3, 594);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1339, 189);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(33, 11, 97);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(820, 99);
            button3.Name = "button3";
            button3.Size = new Size(132, 44);
            button3.TabIndex = 2;
            button3.Text = "Xóa ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(33, 11, 97);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(586, 99);
            button2.Name = "button2";
            button2.Size = new Size(132, 44);
            button2.TabIndex = 1;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 11, 97);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(349, 99);
            button1.Name = "button1";
            button1.Size = new Size(132, 44);
            button1.TabIndex = 0;
            button1.Text = "Nhập hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // KhoHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "KhoHang";
            Size = new Size(1345, 786);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private TextBox textBox1;
    }
}
