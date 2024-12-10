using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp12
{
    public partial class formdangnhap : Form
    {
        public formdangnhap()
        {
            InitializeComponent();
            textBox1.Text = "Username";
            textBox1.ForeColor = Color.Gray;

            textBox2.Text = "Password";
            textBox2.ForeColor = Color.Gray;
            textBox2.UseSystemPasswordChar = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Username";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;
            }
        }
        public static string userRole = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBox1.Text.Trim();
            string matKhau = textBox2.Text.Trim();

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM NguoiDung WHERE Username = @TaiKhoan AND Password = @MatKhau";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            userRole = result.ToString();
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau form1 = new QuenMatKhau();
            form1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formdangky frmDangKy = new formdangky();
            frmDangKy.Show();
        }
    }
}
