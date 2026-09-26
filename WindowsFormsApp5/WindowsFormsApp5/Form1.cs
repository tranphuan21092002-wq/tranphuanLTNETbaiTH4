using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        // Su dung chung cho tat ca cac nut so tu 0 den 9
        private void btnNum_Click(object sender, EventArgs e)
        {
            // Lay nut vua duoc nhan
            Button btn = (Button)sender;

            // Lay Text cua nut va noi vao TextBox
            txtDisplay.Text += btn.Text;
        }

        // Su kien nut Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
    }
}