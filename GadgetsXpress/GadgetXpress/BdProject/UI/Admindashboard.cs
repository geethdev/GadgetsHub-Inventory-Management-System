using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdProject.UI
{
    public partial class frmAdminDashBoard : Form
    {
        public frmAdminDashBoard()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();

        }

        private void frmAdminDashBoard_Load(object sender, EventArgs e)
        {
            lblLogedinUser.Text = frmLogin.loggedIn;
        }

        private void frmAdminDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void lblLoginUser_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories category = new frmCategories();
            category.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();

            products.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust DeaCust = new frmDeaCust();
            DeaCust.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions transaction = new frmTransactions();
            transaction.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();    
            inventory.Show();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmCategories category = new frmCategories();
            category.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();

            products.Show();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            frmDeaCust DeaCust = new frmDeaCust();
            DeaCust.Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            frmTransactions transaction = new frmTransactions();
            transaction.Show();
        }
    }
}
