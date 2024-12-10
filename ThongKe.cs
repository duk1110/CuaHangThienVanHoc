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
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
            LoadHoaDon();
        }

        private void LoadHoaDon()
        {
            string connectionString = "Server=localhost;Database=cuahangthienvanhoc;User ID=root;Password=771099;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM DonHang";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                    string totalAmountQuery = "SELECT TotalAmount FROM DonHang";
                    MySqlCommand cmdTotalAmount = new MySqlCommand(totalAmountQuery, conn);
                    MySqlDataReader reader = cmdTotalAmount.ExecuteReader();

                    decimal totalAmount = 0;
                    while (reader.Read())
                    {
                        totalAmount += reader.GetDecimal("TotalAmount");
                    }

                    textBox1.Text = totalAmount.ToString("C2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string hoaDonID = dataGridView1.SelectedRows[0].Cells["OrderID"].Value.ToString();
                chitietDH formChiTiet = new chitietDH(hoaDonID);
                formChiTiet.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            LoadHoaDon();
        }
    }
}
