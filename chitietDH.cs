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

    public partial class chitietDH : Form
    {

        public string HoaDonID { get; set; }
        public chitietDH(string hoaDonID)
        {
            InitializeComponent();
            this.HoaDonID = hoaDonID;
            LoadChiTietHoaDon();
            LoadThongTinDonHang();
        }

        private void LoadChiTietHoaDon()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT OrderDetailID, ProductName, Quantity, UnitPrice, TotalPrice FROM ChitietDH WHERE OrderID = @HoaDonID";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@HoaDonID", HoaDonID);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadThongTinDonHang()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT dh.OrderID, dh.CustomerName, dh.Phone, dh.Address, dh.EmployeeID FROM DonHang dh " +
                                   "WHERE dh.OrderID = @HoaDonID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@HoaDonID", HoaDonID);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        textBox1.Text = reader["OrderID"].ToString();
                        textBox2.Text = reader["CustomerName"].ToString();
                        textBox3.Text = reader["Phone"].ToString();
                        textBox4.Text = reader["Address"].ToString();
                        textBox5.Text = reader["EmployeeID"].ToString();  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải thông tin đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
