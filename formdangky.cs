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
using System.Windows.Forms;

namespace WinFormsApp12
{
    public partial class formdangky : Form
    {
        public formdangky()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=cuahangthienvanhoc;uid=root;pwd=771099;";

            if (textBox1.Text == "Username" || textBox2.Text == "Password" ||
                textBox3.Text == "Nhập lại password" || textBox4.Text == "Email" ||
                textBox5.Text == "PhoneNumber")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedRole = radioButton1.Checked ? "admin" : "employee";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO nguoidung (Username, Password, Email, PhoneNumber, Role) " +
                                   "VALUES (@Username, @Password, @Email, @PhoneNumber, @Role)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNumber", textBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@Role", selectedRole);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
