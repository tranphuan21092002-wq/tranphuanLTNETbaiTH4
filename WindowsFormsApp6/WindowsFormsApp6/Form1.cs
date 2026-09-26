using System;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cau hinh PictureBox
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Nut CHON ANH
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            // Chi hien thi file anh JPG va PNG
            openFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png";

            openFileDialog1.Title = "Chon anh Avatar";

            // Mo hop thoai chon file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lay duong dan anh va hien thi len PictureBox
                picAvatar.ImageLocation =
                    openFileDialog1.FileName;
            }
        }

        // Nut XUAT CSV
        private void btnXuatCSV_Click(object sender, EventArgs e)
        {
            // Chi cho phep luu file CSV
            saveFileDialog1.Filter =
                "CSV Files|*.csv";

            saveFileDialog1.Title = "Chon noi luu file CSV";

            // Ten file mac dinh
            saveFileDialog1.FileName = "DuLieu.csv";

            // Mo hop thoai luu file
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(
                    "Da chon noi luu file:\n" +
                    saveFileDialog1.FileName,
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}