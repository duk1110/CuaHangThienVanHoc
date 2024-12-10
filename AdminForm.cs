using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            if (formdangnhap.userRole == "employee")
            {
                button_nhacungcap.Visible = false;
                button_nhanvien.Visible = false;
                button_thongke.Visible = false;
            }
            else
            {
                button_nhacungcap.Visible = true;
                button_nhanvien.Visible = true;
                button_thongke.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc bạn muốn đăng xuất?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                formdangnhap form1 = new formdangnhap();
                form1.Show();
                this.Hide();
            }
        }

        private void button_sanpham_Click(object sender, EventArgs e)
        {
            trangchu1.Visible = false;
            sanPham1.Visible = true;
            nhanVien1.Visible = false;
            taoDonHang1.Visible = false;
            nhaCungCap1.Visible = false;
            khoHang1.Visible = false;
            thongKe1.Visible = false;
        }

        private void button_nhanvien_Click(object sender, EventArgs e)
        {
            trangchu1.Visible=false;
            sanPham1.Visible = false;
            nhanVien1.Visible = true;
            taoDonHang1.Visible = false;
            nhaCungCap1.Visible = false;
            khoHang1.Visible = false;
            thongKe1.Visible = false;
        }

        private void button_taodonhang_Click(object sender, EventArgs e)
        {
            trangchu1.Visible=false;
            sanPham1.Visible = false;
            nhanVien1.Visible = false;
            taoDonHang1.Visible = true;
            nhaCungCap1.Visible = false;
            khoHang1.Visible = false;
            thongKe1.Visible = false;
        }

        private void button_nhacungcap_Click(object sender, EventArgs e)
        {
            trangchu1.Visible=false;
            sanPham1.Visible = false;
            nhanVien1.Visible = false;
            taoDonHang1.Visible = false;
            nhaCungCap1.Visible = true;
            khoHang1.Visible = false;
            thongKe1.Visible = false;
        }

        private void button_khohang_Click(object sender, EventArgs e)
        {
            trangchu1.Visible=false;
            sanPham1.Visible = false;
            nhanVien1.Visible = false;
            taoDonHang1.Visible = false;
            nhaCungCap1.Visible = false;
            khoHang1.Visible = true;
            thongKe1.Visible = false;
        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
            trangchu1.Visible=false;
            sanPham1.Visible = false;
            nhanVien1.Visible = false;
            taoDonHang1.Visible = false;
            nhaCungCap1.Visible = false;
            khoHang1.Visible = false;
            thongKe1.Visible = true;
        }

        private void button_trangchu_Click(object sender, EventArgs e)
        {
            trangchu1.Visible=true;
            sanPham1.Visible = false;
            nhanVien1.Visible = false;
            taoDonHang1.Visible = false;
            nhaCungCap1.Visible = false;
            khoHang1.Visible = false;
            thongKe1.Visible = false;
        }
    }
}
