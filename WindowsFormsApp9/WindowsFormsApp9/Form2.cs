using System;
using System.Windows.Forms;
using WindowsFormsApp9;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // Form2 la MDI Parent
            this.IsMdiContainer = true;
        }

        private void menuDangKy_Click(object sender, EventArgs e)
        {
            // Tao Form1 lam cua so con
            Form1 child = new Form1();

            // Dat Form1 nam ben trong Form2
            child.MdiParent = this;

            // Hien Form1
            child.Show();
        }
    }
}