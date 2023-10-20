using BdProject.DAL;
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
    public partial class frmTransactions : Form
    {
        public frmTransactions()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        transactionDALL tdal = new transactionDALL();
        private void frmTransactions_Load(object sender, EventArgs e)
        {
            //display all the transactions
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }

        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the value from the combobox
            string type = cmbTransactionType.Text;

            DataTable dt = tdal.DisplayTransactionByType(type);
            dgvTransactions.DataSource= dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //display all transactions
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTransactionType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //get the value from the combobox
            string type = cmbTransactionType.Text;

            DataTable dt = tdal.DisplayTransactionByType(type);
            dgvTransactions.DataSource = dt;
        }

        private void btnAll_Click_1(object sender, EventArgs e)
        {
            //display all transactions
            DataTable dt = tdal.DisplayAllTransactions();
            dgvTransactions.DataSource = dt;
        }
    }
}
