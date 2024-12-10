namespace WinFormsApp12
{
    partial class formdangnhap
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
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.telescope_icon_icons_com_56329;
            pictureBox1.Location = new Point(107, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 177);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(107, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 36);
            textBox1.TabIndex = 1;
            textBox1.Text = "Username";
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(107, 282);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 36);
            textBox2.TabIndex = 2;
            textBox2.Text = "Password";
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(107, 390);
            button1.Name = "button1";
            button1.Size = new Size(282, 34);
            button1.TabIndex = 3;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_username_people_account_avatar_profile_person_icon_258962;
            pictureBox2.Location = new Point(48, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mbrilock_995951;
            pictureBox3.Location = new Point(48, 282);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(107, 349);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên Mật Khẩu?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(299, 349);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(78, 25);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Đăng Ký";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // formdangnhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 467);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "formdangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formdangnhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}