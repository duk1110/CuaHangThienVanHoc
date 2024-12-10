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

namespace WinFormsApp12
{
    public partial class capnhathanghoa : Form
    {

        private string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

        public capnhathanghoa()
        {
            InitializeComponent();
            LoadProductList();
        }

        private void LoadProductList()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName, SuplierID, CategoryID, Origin, UnitPrice FROM SanPham";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string maSP = dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString();
                int soLuongNhap;

                if (int.TryParse(textBox1.Text, out soLuongNhap))
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string query = "UPDATE KhoHang SET SoLuongTon = SoLuongTon + @SoLuong WHERE MaSP = @MaSP";
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@SoLuong", soLuongNhap);
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProductList();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số nguyên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhập số lượng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
