namespace WinFormsApp12
{
    partial class AdminForm
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button_taodonhang = new Button();
            button_nhacungcap = new Button();
            button_trangchu = new Button();
            label3 = new Label();
            button5 = new Button();
            button_thongke = new Button();
            button_khohang = new Button();
            button_nhanvien = new Button();
            button_sanpham = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            thongKe1 = new ThongKe();
            khoHang1 = new KhoHang();
            nhaCungCap1 = new NhaCungCap();
            taoDonHang1 = new TaoDonHang();
            nhanVien1 = new NhanVien();
            sanPham1 = new SanPham();
            trangchu1 = new Trangchu();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 11, 97);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1645, 45);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(351, 22);
            label1.TabIndex = 0;
            label1.Text = "Astronomy Shop Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 11, 97);
            panel2.Controls.Add(button_taodonhang);
            panel2.Controls.Add(button_nhacungcap);
            panel2.Controls.Add(button_trangchu);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button_thongke);
            panel2.Controls.Add(button_khohang);
            panel2.Controls.Add(button_nhanvien);
            panel2.Controls.Add(button_sanpham);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 786);
            panel2.TabIndex = 1;
            // 
            // button_taodonhang
            // 
            button_taodonhang.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button_taodonhang.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button_taodonhang.FlatStyle = FlatStyle.Flat;
            button_taodonhang.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_taodonhang.ForeColor = Color.White;
            button_taodonhang.Location = new Point(38, 425);
            button_taodonhang.Name = "button_taodonhang";
            button_taodonhang.Size = new Size(215, 50);
            button_taodonhang.TabIndex = 10;
            button_taodonhang.Text = "Tạo đơn hàng";
            button_taodonhang.UseVisualStyleBackColor = true;
            button_taodonhang.Click += button_taodonhang_Click;
            // 
            // button_nhacungcap
            // 
            button_nhacungcap.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button_nhacungcap.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button_nhacungcap.FlatStyle = FlatStyle.Flat;
            button_nhacungcap.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_nhacungcap.ForeColor = Color.White;
            button_nhacungcap.Location = new Point(38, 481);
            button_nhacungcap.Name = "button_nhacungcap";
            button_nhacungcap.Size = new Size(215, 50);
            button_nhacungcap.TabIndex = 9;
            button_nhacungcap.Text = "Nhà cung cấp";
            button_nhacungcap.UseVisualStyleBackColor = true;
            button_nhacungcap.Click += button_nhacungcap_Click;
            // 
            // button_trangchu
            // 
            button_trangchu.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button_trangchu.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button_trangchu.FlatStyle = FlatStyle.Flat;
            button_trangchu.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_trangchu.ForeColor = Color.White;
            button_trangchu.Location = new Point(38, 257);
            button_trangchu.Name = "button_trangchu";
            button_trangchu.Size = new Size(215, 50);
            button_trangchu.TabIndex = 8;
            button_trangchu.Text = "Trang chủ";
            button_trangchu.UseVisualStyleBackColor = true;
            button_trangchu.Click += button_trangchu_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(73, 736);
            label3.Name = "label3";
            label3.Size = new Size(87, 22);
            label3.TabIndex = 7;
            label3.Text = "Sign Out";
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.icons8_logout_rounded_up_33px;
            button5.Location = new Point(12, 719);
            button5.Name = "button5";
            button5.Size = new Size(55, 55);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button_thongke
            // 
            button_thongke.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button_thongke.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button_thongke.FlatStyle = FlatStyle.Flat;
            button_thongke.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_thongke.ForeColor = Color.White;
            button_thongke.Location = new Point(38, 593);
            button_thongke.Name = "button_thongke";
            button_thongke.Size = new Size(215, 50);
            button_thongke.TabIndex = 5;
            button_thongke.Text = "Thống kê";
            button_thongke.UseVisualStyleBackColor = true;
            button_thongke.Click += button_thongke_Click;
            // 
            // button_khohang
            // 
            button_khohang.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button_khohang.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button_khohang.FlatStyle = FlatStyle.Flat;
            button_khohang.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_khohang.ForeColor = Color.White;
            button_khohang.Location = new Point(38, 537);
            button_khohang.Name = "button_khohang";
            button_khohang.Size = new Size(215, 50);
            button_khohang.TabIndex = 4;
            button_khohang.Text = "Kho hàng";
            button_khohang.UseVisualStyleBackColor = true;
            button_khohang.Click += button_khohang_Click;
            // 
            // button_nhanvien
            // 
            button_nhanvien.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button_nhanvien.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button_nhanvien.FlatStyle = FlatStyle.Flat;
            button_nhanvien.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_nhanvien.ForeColor = Color.White;
            button_nhanvien.Location = new Point(38, 369);
            button_nhanvien.Name = "button_nhanvien";
            button_nhanvien.Size = new Size(215, 50);
            button_nhanvien.TabIndex = 3;
            button_nhanvien.Text = "Nhân viên";
            button_nhanvien.UseVisualStyleBackColor = true;
            button_nhanvien.Click += button_nhanvien_Click;
            // 
            // button_sanpham
            // 
            button_sanpham.FlatAppearance.MouseDownBackColor = Color.FromArgb(75, 8, 138);
            button_sanpham.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 8, 138);
            button_sanpham.FlatStyle = FlatStyle.Flat;
            button_sanpham.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_sanpham.ForeColor = Color.White;
            button_sanpham.Location = new Point(38, 313);
            button_sanpham.Name = "button_sanpham";
            button_sanpham.Size = new Size(215, 50);
            button_sanpham.TabIndex = 2;
            button_sanpham.Text = "Sản phẩm";
            button_sanpham.UseVisualStyleBackColor = true;
            button_sanpham.Click += button_sanpham_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(64, 198);
            label2.Name = "label2";
            label2.Size = new Size(162, 22);
            label2.TabIndex = 1;
            label2.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.telescope_icon_icons_com_56329;
            pictureBox1.Location = new Point(38, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(trangchu1);
            panel3.Controls.Add(thongKe1);
            panel3.Controls.Add(khoHang1);
            panel3.Controls.Add(nhaCungCap1);
            panel3.Controls.Add(taoDonHang1);
            panel3.Controls.Add(nhanVien1);
            panel3.Controls.Add(sanPham1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(300, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(1345, 786);
            panel3.TabIndex = 2;
            // 
            // thongKe1
            // 
            thongKe1.Location = new Point(0, 0);
            thongKe1.Name = "thongKe1";
            thongKe1.Size = new Size(2018, 1179);
            thongKe1.TabIndex = 5;
            // 
            // khoHang1
            // 
            khoHang1.Location = new Point(0, 0);
            khoHang1.Name = "khoHang1";
            khoHang1.Size = new Size(2018, 1179);
            khoHang1.TabIndex = 4;
            // 
            // nhaCungCap1
            // 
            nhaCungCap1.Location = new Point(0, 0);
            nhaCungCap1.Name = "nhaCungCap1";
            nhaCungCap1.Size = new Size(2018, 1179);
            nhaCungCap1.TabIndex = 3;
            // 
            // taoDonHang1
            // 
            taoDonHang1.Location = new Point(0, 0);
            taoDonHang1.Name = "taoDonHang1";
            taoDonHang1.Size = new Size(2018, 1179);
            taoDonHang1.TabIndex = 2;
            // 
            // nhanVien1
            // 
            nhanVien1.Location = new Point(0, 0);
            nhanVien1.Name = "nhanVien1";
            nhanVien1.Size = new Size(2018, 1179);
            nhanVien1.TabIndex = 1;
            // 
            // sanPham1
            // 
            sanPham1.Location = new Point(0, 0);
            sanPham1.Name = "sanPham1";
            sanPham1.Size = new Size(2018, 1179);
            sanPham1.TabIndex = 0;
            // 
            // trangchu1
            // 
            trangchu1.Location = new Point(0, 0);
            trangchu1.Name = "trangchu1";
            trangchu1.Size = new Size(2008, 820);
            trangchu1.TabIndex = 6;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 831);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button_sanpham;
        private Button button5;
        private Button button_thongke;
        private Button button_khohang;
        private Button button_nhanvien;
        private Label label3;
        private Panel panel3;
        private Button button_taodonhang;
        private Button button_nhacungcap;
        private Button button_trangchu;
        private ThongKe thongKe1;
        private KhoHang khoHang1;
        private NhaCungCap nhaCungCap1;
        private TaoDonHang taoDonHang1;
        private NhanVien nhanVien1;
        private SanPham sanPham1;
        private Trangchu trangchu1;
    }
}