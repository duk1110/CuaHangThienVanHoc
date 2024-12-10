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
    public partial class NhaCungCap : UserControl
    {
        public NhaCungCap()
        {
            InitializeComponent();
            LoadNhaCC();
        }

        private void LoadNhaCC()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SupplierID, SupplierName, Hotline, Email from NhaCC";

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
            string supplierID = textBox1.Text.Trim();
            string supplierName = textBox2.Text.Trim();
            string hotline = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(supplierID) || string.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO NhaCC (SupplierID, SupplierName, Hotline, Email) VALUES (@SupplierID, @SupplierName, @Hotline, @Email)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        cmd.Parameters.AddWithValue("@Hotline", hotline);
                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.ExecuteNonQuery();              

                        MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadNhaCC();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string supplierID = textBox1.Text.Trim();
            string supplierName = textBox2.Text.Trim();
            string hotline = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();

            if (string.IsNullOrWhiteSpace(supplierID) || string.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE NhaCC SET SupplierName = @SupplierName, Hotline = @Hotline, Email = @Email WHERE SupplierID = @SupplierID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                        cmd.Parameters.AddWithValue("@SupplierName", supplierName);
                        cmd.Parameters.AddWithValue("@Hotline", hotline);
                        cmd.Parameters.AddWithValue("@Email", email);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadNhaCC();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["SupplierID"].Value.ToString();
                textBox2.Text = row.Cells["SupplierName"].Value.ToString();
                textBox3.Text = row.Cells["Hotline"].Value.ToString();
                textBox4.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string supplierID = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(supplierID))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM NhaCC WHERE SupplierID = @SupplierID";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadNhaCC();

                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



    private void button4_Click(object sender, EventArgs e)
        {
            LoadNhaCC();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string supplierName = textBox5.Text.Trim();

            if (string.IsNullOrWhiteSpace(supplierName))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp để tìm kiếm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SupplierID, SupplierName, Hotline, Email FROM NhaCC WHERE SupplierName LIKE @SupplierName";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierName", $"%{supplierName}%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhà cung cấp nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tìm kiếm nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
