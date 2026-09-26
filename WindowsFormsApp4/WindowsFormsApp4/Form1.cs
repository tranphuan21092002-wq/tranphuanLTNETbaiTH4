using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        // Luu gia tien cua tung mon an
        Dictionary<string, int> prices = new Dictionary<string, int>()
        {
            { "Hamburger", 50000 },
            { "Pizza", 120000 },
            { "Ga Ran", 35000 },
            { "Pepsi", 15000 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Su kien khi Form duoc mo
        private void Form1_Load(object sender, EventArgs e)
        {
            // Xoa danh sach cu
            lstMenu.Items.Clear();
            lstSelected.Items.Clear();

            // Them mon an vao ListBox
            lstMenu.Items.Add("Hamburger");
            lstMenu.Items.Add("Pizza");
            lstMenu.Items.Add("Ga Ran");
            lstMenu.Items.Add("Pepsi");

            // Hien tong tien ban dau
            lblTotal.Text = "Tong tien: 0 VNĐ";
        }

        // =====================================
        // NUT > : CHUYEN MON SANG DANH SACH DA CHON
        // =====================================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiem tra co chon mon hay chua
            if (lstMenu.SelectedItem != null)
            {
                // Lay mon an dang chon
                string food = lstMenu.SelectedItem.ToString();

                // Them mon sang danh sach da chon
                lstSelected.Items.Add(food);

                // Xoa mon khoi danh sach mon an
                lstMenu.Items.Remove(lstMenu.SelectedItem);

                // Cap nhat tong tien
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Vui long chon mon an!");
            }
        }

        // =====================================
        // NUT < : XOA MON KHOI DANH SACH DA CHON
        // =====================================
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Kiem tra xem da chon mon trong danh sach chua
            if (lstSelected.SelectedItem != null)
            {
                // Lay mon dang chon
                string food = lstSelected.SelectedItem.ToString();

                // Xoa mon khoi danh sach da chon
                lstSelected.Items.Remove(lstSelected.SelectedItem);

                // Tra mon ve lai danh sach menu
                lstMenu.Items.Add(food);

                // Cap nhat tong tien
                UpdateTotal();
            }
            else
            {
                MessageBox.Show("Vui long chon mon can xoa!");
            }
        }

        // =====================================
        // CAP NHAT TONG TIEN
        // =====================================
        private void UpdateTotal()
        {
            int total = 0;

            // Duyet qua tat ca mon trong danh sach da chon
            foreach (var item in lstSelected.Items)
            {
                string food = item.ToString();

                // Cong gia tien
                if (prices.ContainsKey(food))
                {
                    total += prices[food];
                }
            }

            // Hien tong tien
            lblTotal.Text = "Tong tien: " + total.ToString("N0") + " VNĐ";
        }
    }
}