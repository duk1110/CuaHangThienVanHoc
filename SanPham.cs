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
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
            LoadData();
            LoadDanhmuc();
            LoadSuppliers();
            LoadDanhmuc1();
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

                    comboBox3.Items.Clear();

                    DataRow allCategoriesRow = dataTable.NewRow();
                    allCategoriesRow["CategoryID"] = DBNull.Value;
                    allCategoriesRow["CategoryName"] = "Tất cả sản phẩm";
                    dataTable.Rows.InsertAt(allCategoriesRow, 0);

                    comboBox3.DisplayMember = "CategoryName";
                    comboBox3.ValueMember = "CategoryID";
                    comboBox3.DataSource = dataTable;
                    comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedValue != null && comboBox3.SelectedValue != DBNull.Value)
            {
                int selectedCategoryID = Convert.ToInt32(comboBox3.SelectedValue);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ProductID"].Value.ToString();
                textBox2.Text = row.Cells["ProductName"].Value.ToString();
                comboBox4.SelectedValue = row.Cells["SuplierID"].Value;
                comboBox1.SelectedValue = row.Cells["CategoryID"].Value;
                comboBox2.Text = row.Cells["Origin"].Value.ToString();
                textBox7.Text = row.Cells["UnitPrice"].Value.ToString();
                richTextBox2.Text = row.Cells["Description"].Value.ToString();
                pictureBox1.ImageLocation = row.Cells["ImagePath"].Value.ToString();

                richTextBox1.Text = row.Cells["Description"].Value.ToString();

                string imagePath = row.Cells["ImagePath"].Value.ToString();
                if (File.Exists(imagePath))
                {
                    pictureBox2.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox2.Image = null;
                    MessageBox.Show("Không tìm thấy ảnh sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void LoadSuppliers()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SupplierID, SupplierName FROM NhaCC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    comboBox4.DataSource = dataTable;
                    comboBox4.DisplayMember = "SupplierName";
                    comboBox4.ValueMember = "SupplierID";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDanhmuc1()
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

                    comboBox1.Items.Clear();
                    comboBox1.DisplayMember = "CategoryName";
                    comboBox1.ValueMember = "CategoryID";
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
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || comboBox1.SelectedValue == null || comboBox4.SelectedValue == null || string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string productID = textBox1.Text;
            string productName = textBox2.Text;
            string supplierID = comboBox4.SelectedValue.ToString();
            string description = richTextBox2.Text;
            string categoryID = comboBox1.SelectedValue.ToString();
            string origin = comboBox2.Text;
            decimal unitPrice = Convert.ToDecimal(textBox7.Text);
            string imagePath = pictureBox1.ImageLocation ?? string.Empty;

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM SanPham WHERE ProductID = @ProductID";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@ProductID", productID);

                    int existingProductCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (existingProductCount > 0)
                    {
                        MessageBox.Show("Mã sản phẩm này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string query = "INSERT INTO SanPham (ProductID, ProductName, SuplierID, CategoryID, Origin, UnitPrice, Description, ImagePath) " +
                                   "VALUES (@ProductID, @ProductName, @SuplierID, @CategoryID, @Origin, @UnitPrice, @Description, @ImagePath)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@Origin", origin);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                    cmd.Parameters.AddWithValue("@SuplierID", supplierID);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Chọn Hình Ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = imagePath;

                string connectionString = "Server=localhost;Database=cuahangthienvanhoc;Uid=root;Pwd=771099;";
                string query = "INSERT INTO SanPham (ProductID, ProductName, SuplierID, Description, CategoryID, Origin, UnitPrice, ImagePath) " +
                               "VALUES (@ProductID, @ProductName, @SuplierID, @Description, @CategoryID, @Origin, @UnitPrice, @ImagePath)";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", textBox1.Text);
                        cmd.Parameters.AddWithValue("@ProductName", textBox2.Text);
                        cmd.Parameters.AddWithValue("@SuplierID", comboBox4.SelectedValue);
                        cmd.Parameters.AddWithValue("@Description", richTextBox2.Text);
                        cmd.Parameters.AddWithValue("@CategoryID", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@Origin", comboBox2.Text);
                        cmd.Parameters.AddWithValue("@UnitPrice", Convert.ToDecimal(textBox7.Text));
                        cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string productID = textBox1.Text;
            string productName = textBox2.Text;
            string suplierID = comboBox4.SelectedValue.ToString();
            string categoryID = comboBox1.SelectedValue.ToString();
            string origin = comboBox2.Text;
            decimal unitPrice = Convert.ToDecimal(textBox7.Text);
            string description = richTextBox2.Text;
            string imagePath = pictureBox1.ImageLocation ?? string.Empty;

            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE SanPham SET ProductName = @ProductName, SuplierID = @SuplierID, CategoryID = @CategoryID, " +
                                         "Origin = @Origin, UnitPrice = @UnitPrice, Description = @Description, ImagePath = @ImagePath " +
                                         "WHERE ProductID = @ProductID";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@SuplierID", suplierID);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    cmd.Parameters.AddWithValue("@Origin", origin);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm với mã ID này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool DeleteProductFromDatabase(string productId)
        {
            try
            {
                string connectionString = "Server=localhost;Database=cuahangthienvanhoc;Uid=root;Pwd=771099;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM SanPham WHERE ProductID = @ProductID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductID", productId);
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối với cơ sở dữ liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string productId = row.Cells["ProductID"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    bool isDeleted = DeleteProductFromDatabase(productId);

                    if (isDeleted)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                        MessageBox.Show("Sản phẩm đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox7.Clear();
            comboBox4.SelectedIndex = -1;  
            comboBox1.SelectedIndex = -1;   
            comboBox2.SelectedIndex = -1;
            richTextBox2.Clear();
            pictureBox1.Image = null;
            LoadData();
            LoadSuppliers();
        }
    }
}
