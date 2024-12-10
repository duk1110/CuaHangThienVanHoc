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
    public partial class KhoHang : UserControl
    {
        private string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

        public KhoHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData(string searchKeyword = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM KhoHang";

                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += " WHERE TenSanPham LIKE @searchKeyword";
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@searchKeyword", "%" + searchKeyword + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["MaSP"].Width = 250;
                    dataGridView1.Columns["TenSanPham"].Width = 250;
                    dataGridView1.Columns["SoLuongTon"].Width = 250;
                    dataGridView1.Columns["NgayNhap"].Width = 250;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không hiển thị " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            capnhathanghoa formNhapHang = new capnhathanghoa();
            formNhapHang.ShowDialog();
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text.Trim();
            LoadData(searchKeyword);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string productID = dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi cả kho và danh sách sản phẩm?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            using (MySqlTransaction transaction = conn.BeginTransaction())
                            {
                                string deleteKhoHangQuery = "DELETE FROM KhoHang WHERE MaSP = @ProductID";
                                MySqlCommand deleteKhoHangCmd = new MySqlCommand(deleteKhoHangQuery, conn, transaction);
                                deleteKhoHangCmd.Parameters.AddWithValue("@ProductID", productID);
                                deleteKhoHangCmd.ExecuteNonQuery();

                                string deleteSanPhamQuery = "DELETE FROM SanPham WHERE ProductID = @ProductID";
                                MySqlCommand deleteSanPhamCmd = new MySqlCommand(deleteSanPhamQuery, conn, transaction);
                                deleteSanPhamCmd.Parameters.AddWithValue("@ProductID", productID);
                                deleteSanPhamCmd.ExecuteNonQuery();

                                transaction.Commit();
                                LoadData();

                                MessageBox.Show("Sản phẩm đã được xóa thành công khỏi kho và danh sách sản phẩm!",
                                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
