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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp12
{
    public partial class TaoDonHang : UserControl
    {

        private string selectedProductID;
        private string selectedProductName;
        private decimal selectedUnitPrice;
        public TaoDonHang()
        {
            InitializeComponent();
            LoadData();
            LoadDanhmuc();
            LoadNhanvien();
        }

        private void LoadData()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ProductID, ProductName, SuplierID, CategoryID, Origin, UnitPrice, Description, ImagePath FROM SanPham";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["Description"].Visible = false;
                    dataGridView1.Columns["ImagePath"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDanhmuc()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CategoryID, CategoryName FROM DanhMuc";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBox2.Items.Clear();

                    DataRow allCategoriesRow = dataTable.NewRow();
                    allCategoriesRow["CategoryID"] = DBNull.Value;
                    allCategoriesRow["CategoryName"] = "Tất cả sản phẩm";
                    dataTable.Rows.InsertAt(allCategoriesRow, 0);

                    comboBox2.DisplayMember = "CategoryName";
                    comboBox2.ValueMember = "CategoryID";
                    comboBox2.DataSource = dataTable;
                    comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue != null && comboBox2.SelectedValue != DBNull.Value)
            {
                int selectedCategoryID = Convert.ToInt32(comboBox2.SelectedValue);
                LoadProductsByCategory(selectedCategoryID);
            }
            else
            {
                LoadData();
            }
        }
        private void LoadProductsByCategory(int categoryID)
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT ProductID, ProductName, SuplierID, CategoryID, Origin, UnitPrice, ImagePath, Description " +
                                   "FROM SanPham WHERE CategoryID = @CategoryID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["Description"].Visible = false;
                    dataGridView1.Columns["ImagePath"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadNhanvien()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaNV from NhanVien";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    comboBox1.Items.Clear();
                    comboBox1.DisplayMember = "MaNV";
                    comboBox1.ValueMember = "MaNV";
                    comboBox1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedProductID) && numericUpDown1.Value > 0)
            {
                int quantity = (int)numericUpDown1.Value;
                decimal totalPrice = quantity * selectedUnitPrice;
                dataGridView2.Rows.Add(selectedProductID, selectedProductName, quantity, selectedUnitPrice, totalPrice);

                MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm và số lượng hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedProductID = dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                selectedProductName = dataGridView1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                selectedUnitPrice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    string orderID = textBox1.Text;
                    string customerName = textBox2.Text;
                    string phone = textBox3.Text;
                    string address = textBox4.Text;
                    string maNV = comboBox1.SelectedValue.ToString();
                    DateTime ngayTao = DateTime.Now;

                    decimal totalAmount = 0;

                    string checkOrderIDQuery = "SELECT COUNT(*) FROM DonHang WHERE OrderID = @OrderID";
                    MySqlCommand checkOrderIDCommand = new MySqlCommand(checkOrderIDQuery, conn);
                    checkOrderIDCommand.Parameters.AddWithValue("@OrderID", orderID);
                    int count = Convert.ToInt32(checkOrderIDCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Đơn hàng với OrderID này đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; 
                    }

                    string insertDonHang = "INSERT INTO DonHang (OrderID, CustomerName, Phone, Address, EmployeeID, OrderDate, TotalAmount) " +
                                           "VALUES (@OrderID, @CustomerName, @Phone, @Address, @EmployeeID, @OrderDate, @TotalAmount)";
                    MySqlCommand cmdDonHang = new MySqlCommand(insertDonHang, conn, transaction);
                    cmdDonHang.Parameters.AddWithValue("@OrderID", orderID);
                    cmdDonHang.Parameters.AddWithValue("@CustomerName", customerName);
                    cmdDonHang.Parameters.AddWithValue("@Phone", phone);
                    cmdDonHang.Parameters.AddWithValue("@Address", address);
                    cmdDonHang.Parameters.AddWithValue("@EmployeeID", maNV);
                    cmdDonHang.Parameters.AddWithValue("@OrderDate", ngayTao);
                    cmdDonHang.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmdDonHang.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string productID = row.Cells["Column1"].Value.ToString();
                        string productName = row.Cells["Column2"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Column3"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["Column4"].Value);

                        string insertChiTiet = "INSERT INTO ChitietDH (OrderID, ProductID, ProductName, Quantity, UnitPrice) " +
                                               "VALUES (@OrderID, @ProductID, @ProductName, @Quantity, @UnitPrice)";
                        MySqlCommand cmdChiTiet = new MySqlCommand(insertChiTiet, conn, transaction);
                        cmdChiTiet.Parameters.AddWithValue("@OrderID", orderID);
                        cmdChiTiet.Parameters.AddWithValue("@ProductID", productID);
                        cmdChiTiet.Parameters.AddWithValue("@ProductName", productName);
                        cmdChiTiet.Parameters.AddWithValue("@Quantity", quantity);
                        cmdChiTiet.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        cmdChiTiet.ExecuteNonQuery();

                        totalAmount += quantity * unitPrice; 
                    }

                    string updateDonHang = "UPDATE DonHang SET TotalAmount = @TotalAmount WHERE OrderID = @OrderID";
                    MySqlCommand cmdUpdateDonHang = new MySqlCommand(updateDonHang, conn, transaction);
                    cmdUpdateDonHang.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    cmdUpdateDonHang.Parameters.AddWithValue("@OrderID", orderID);
                    cmdUpdateDonHang.ExecuteNonQuery();

                    transaction.Commit();

                    button5.Visible = true;
                    MessageBox.Show("Tạo đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Lỗi khi tạo đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView2.SelectedRows[0].Index;
                dataGridView2.Rows.RemoveAt(rowIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1;
            dataGridView2.Rows.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HoaDon form1 = new HoaDon();
            string orderID = textBox1.Text;
            string customerName = textBox2.Text;
            string phone = textBox3.Text;
            string address = textBox4.Text;
            string manv = comboBox1.Text;

            form1.SetOrderDetails(orderID, customerName, phone, address, manv);

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                string productID = row.Cells["Column1"].Value.ToString();
                string productName = row.Cells["Column2"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Column3"].Value);
                decimal unitPrice = Convert.ToDecimal(row.Cells["Column4"].Value);
                decimal totalPrice = Convert.ToDecimal(row.Cells["Column5"].Value);

                form1.AddProductToInvoice(productID, productName, quantity, unitPrice, totalPrice);
            }
            form1.Show();

        }
    }
}
