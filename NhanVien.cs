using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp12
{
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
            LoadNhanvien();
        }

        private void LoadNhanvien()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaNV, HoTen, SDT, QueQuan, Email, TaiKhoan, MatKhau from NhanVien";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maNV = textBox1.Text.Trim();
            string hoTen = textBox2.Text.Trim();
            string sdt = textBox3.Text.Trim();
            string queQuan = textBox4.Text.Trim();
            string email = textBox5.Text.Trim();
            string taiKhoan = textBox6.Text.Trim();
            string matKhau = textBox7.Text.Trim();

            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MaNV", maNV);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Mã nhân viên đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string queryNguoiDung = "INSERT INTO NguoiDung (Username, Password, Email, Role) VALUES (@TaiKhoan, @MatKhau, @Email, 'Employee')";
                    using (MySqlCommand cmdNguoiDung = new MySqlCommand(queryNguoiDung, conn))
                    {
                        cmdNguoiDung.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmdNguoiDung.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmdNguoiDung.Parameters.AddWithValue("@Email", email);
                        cmdNguoiDung.ExecuteNonQuery();
                    }

                    string queryNhanVien = "INSERT INTO NhanVien (MaNV, HoTen, SDT, QueQuan, Email, TaiKhoan, MatKhau) " +
                                           "VALUES (@MaNV, @HoTen, @SDT, @QueQuan, @Email, @TaiKhoan, @MatKhau)";

                    using (MySqlCommand cmdNhanVien = new MySqlCommand(queryNhanVien, conn))
                    {
                        cmdNhanVien.Parameters.AddWithValue("@MaNV", maNV);
                        cmdNhanVien.Parameters.AddWithValue("@HoTen", hoTen);
                        cmdNhanVien.Parameters.AddWithValue("@SDT", sdt);
                        cmdNhanVien.Parameters.AddWithValue("@QueQuan", queQuan);
                        cmdNhanVien.Parameters.AddWithValue("@Email", email);
                        cmdNhanVien.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmdNhanVien.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmdNhanVien.ExecuteNonQuery();

                        MessageBox.Show("Thêm nhân viên và tài khoản người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadNhanvien();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm nhân viên và tạo tài khoản người dùng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string maNV = textBox1.Text.Trim();
            string hoTen = textBox2.Text.Trim();
            string sdt = textBox3.Text.Trim();
            string queQuan = textBox4.Text.Trim();
            string email = textBox5.Text.Trim();
            string taiKhoan = textBox6.Text.Trim();
            string matKhau = textBox7.Text.Trim();

            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE NhanVien SET HoTen = @HoTen, SDT = @SDT, QueQuan = @QueQuan, Email = @Email, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau WHERE MaNV = @MaNV";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@HoTen", hoTen);
                        cmd.Parameters.AddWithValue("@SDT", sdt);
                        cmd.Parameters.AddWithValue("@QueQuan", queQuan);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadNhanvien();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["MaNV"].Value.ToString();
                textBox2.Text = row.Cells["HoTen"].Value.ToString();
                textBox3.Text = row.Cells["SDT"].Value.ToString();
                textBox4.Text = row.Cells["QueQuan"].Value.ToString();
                textBox5.Text = row.Cells["Email"].Value.ToString();
                textBox6.Text = row.Cells["TaiKhoan"].Value.ToString();
                textBox7.Text = row.Cells["MatKhau"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maNV = textBox1.Text.Trim();
            string taikhoan = textBox6.Text.Trim();
            if (string.IsNullOrWhiteSpace(maNV))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (MySqlTransaction transaction = conn.BeginTransaction())
                        {
                            string deleteAccountQuery = "DELETE FROM NguoiDung WHERE Username = @TaiKhoan";

                            using (MySqlCommand cmd1 = new MySqlCommand(deleteAccountQuery, conn, transaction))
                            {
                                cmd1.Parameters.AddWithValue("@TaiKhoan", taikhoan);
                                cmd1.ExecuteNonQuery();
                            }
                            string deleteEmployeeQuery = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

                            using (MySqlCommand cmd2 = new MySqlCommand(deleteEmployeeQuery, conn, transaction))
                            {
                                cmd2.Parameters.AddWithValue("@MaNV", maNV);
                                cmd2.ExecuteNonQuery();
                            }
                            transaction.Commit();

                            MessageBox.Show("Xóa nhân viên và tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadNhanvien();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string tenNV = textBox8.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenNV))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên để tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaNV, HoTen, SDT, QueQuan, Email, TaiKhoan, MatKhau FROM NhanVien WHERE HoTen LIKE @HoTen";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HoTen", "%" + tenNV + "%");
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            LoadNhanvien();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
