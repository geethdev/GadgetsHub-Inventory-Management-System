using BdProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdProject.UI
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //functianality to close this box
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            //display the categories in combobox
            DataTable cDt = cdal.select();


            cmbCategories.DataSource = cDt;

            //give the value member and display member for combobox
            cmbCategories.DisplayMember = "title";
            cmbCategories.ValueMember = "title";

            //display all the product in data grid view when the product is loaded
            DataTable pdt = pdal.Select();
            dgvProducts.DataSource = pdt;





        }

        /*private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display products based on selected category
            string category = cmbCategories.Text;

            DataTable dt = pdal.DisplayProductByCategory(category);
            dgvProducts.DataSource = dt;


        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //display all the products when button click
            DataTable dt = pdal.Select();
            dgvProducts.DataSource= dt;
        }*/

        private void cmbCategories_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //display products based on selected category
            string category = cmbCategories.Text;

            DataTable dt = pdal.DisplayProductByCategory(category);
            dgvProducts.DataSource = dt;
        }

        private void btnAll_Click_1(object sender, EventArgs e)
        {
            //display all the products when button click
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
}
