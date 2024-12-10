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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            UpdateTotalPrice();
        }

        public void SetOrderDetails(string orderID, string customerName, string phone, string address, string manv)
        {
            textBox1.Text = orderID;
            textBox2.Text = customerName;
            textBox3.Text = phone;
            textBox4.Text = address;
            textBox5.Text = manv;
        }

        public void AddProductToInvoice(string productID, string productName, int quantity, decimal unitPrice, decimal totalPrice)
        {
            dataGridView1.Rows.Add(productID, productName, quantity, unitPrice, totalPrice);
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    total += Convert.ToDecimal(row.Cells["Column5"].Value); 
                }
            }
            textBox6.Text = total.ToString("C"); 
        }
    }
}
