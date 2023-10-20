using BdProject.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdProject
{
    public partial class frmuUserDashboard : Form
    {
        public frmuUserDashboard()
        {
            InitializeComponent();
        }

        //set a public static method to specify whether the form is purchase or sales
        public static string transactionType;

        private void lblFappName_Click(object sender, EventArgs e)
        {

        }

        private void frmuUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void lblLoginUser_Click(object sender, EventArgs e)
        {

        }

        private void frmuUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoginUser.Text = frmLogin.loggedIn;
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeaCust DeaCust = new frmDeaCust();
            DeaCust.Show();
        }

        private void purchaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set value on transaction Type static method
            transactionType = "Purchase";

            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            purchase.Show();


        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set the value of transactionType method to sales
            transactionType = "Sales";

            frmPurchaseAndSales sales = new frmPurchaseAndSales();
            sales.Show();

            
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            //set value on transaction Type static method
            transactionType = "Purchase";

            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            purchase.Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            //set the value of transactionType method to sales
            transactionType = "Sales";

            frmPurchaseAndSales sales = new frmPurchaseAndSales();
            sales.Show();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            frmDeaCust DeaCust = new frmDeaCust();
            DeaCust.Show();
        }
    }
}
