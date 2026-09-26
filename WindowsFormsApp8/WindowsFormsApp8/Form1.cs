using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        // Danh sach san pham dung BindingList
        private BindingList<ProductModel> products =
            new BindingList<ProductModel>();

        public Form1()
        {
            InitializeComponent();
        }

        // Su kien Load cua Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Xoa cac cot cu neu co
            dgvSanPham.Columns.Clear();

            // Khong tu dong tao cot
            dgvSanPham.AutoGenerateColumns = false;

            // Tao cot MaSP
            DataGridViewTextBoxColumn colMaSP =
                new DataGridViewTextBoxColumn();

            colMaSP.Name = "colMaSP";
            colMaSP.HeaderText = "Mã sản phẩm";
            colMaSP.DataPropertyName = "MaSP";

            // Tao cot TenSP
            DataGridViewTextBoxColumn colTenSP =
                new DataGridViewTextBoxColumn();

            colTenSP.Name = "colTenSP";
            colTenSP.HeaderText = "Tên sản phẩm";
            colTenSP.DataPropertyName = "TenSP";

            // Tao cot Gia
            DataGridViewTextBoxColumn colGia =
                new DataGridViewTextBoxColumn();

            colGia.Name = "colGia";
            colGia.HeaderText = "Giá";
            colGia.DataPropertyName = "Gia";

            // Them 3 cot vao DataGridView
            dgvSanPham.Columns.Add(colMaSP);
            dgvSanPham.Columns.Add(colTenSP);
            dgvSanPham.Columns.Add(colGia);

            // Gan BindingList lam nguon du lieu
            dgvSanPham.DataSource = products;
        }

        // Su kien nut THEM
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiem tra ma san pham
            if (string.IsNullOrWhiteSpace(txtMaSP.Text))
            {
                MessageBox.Show(
                    "Vui long nhap ma san pham!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtMaSP.Focus();
                return;
            }

            // Kiem tra ten san pham
            if (string.IsNullOrWhiteSpace(txtTenSP.Text))
            {
                MessageBox.Show(
                    "Vui long nhap ten san pham!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTenSP.Focus();
                return;
            }

            // Kiem tra gia
            decimal gia;

            if (!decimal.TryParse(txtGia.Text, out gia))
            {
                MessageBox.Show(
                    "Gia san pham phai la so!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtGia.Focus();
                return;
            }

            // Tao san pham moi
            ProductModel product = new ProductModel();

            product.MaSP = txtMaSP.Text;
            product.TenSP = txtTenSP.Text;
            product.Gia = gia;

            // Them san pham vao BindingList
            products.Add(product);

            // Xoa du lieu sau khi them
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGia.Clear();

            // Dua con tro ve o Ma SP
            txtMaSP.Focus();
        }

        // Su kien nut XOA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiem tra co dong nao dang duoc chon hay khong
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui long chon san pham can xoa!",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Lay san pham dang duoc chon
            ProductModel product =
                dgvSanPham.CurrentRow.DataBoundItem as ProductModel;

            // Neu lay duoc san pham thi xoa
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}