using BdProject.BLL;
using BdProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdProject.UI
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //add code to hide this form
            this.Hide();
        }

        categoriesDAL cdal = new categoriesDAL();
        productsBLL p= new productsBLL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            //crete datatable to hold the categories from database
            DataTable categoriesDT = cdal.select();

            //specify datasource for category combobox
            cmbCategory.DataSource = categoriesDT;

            //specify display member and value member for combobox
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //load all the products and data grid view
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get all the values from product form
            p.name=txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;


            //getting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            userBLL usr=udal.GetIDFromUsername(loggedUser);

            p.added_by = usr.id;

            //create bool variable to check if the product added successfully or not
            bool success=pdal.Insert(p);

            //if the product is added successfully then the vallue of success will be true else it will be false
            if(success==true)
            {
                //product inserted successfully
                MessageBox.Show("Product added successfully");


                //calling the clear method
                Clear();

                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                //failled to add new product
                MessageBox.Show("Failed to add product");
            }

        }

        public void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //create int variable to know wich product was clicked
            int rowIndex = e.RowIndex;

            //display the value on respective textboxes
            txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the values from ui or product form
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;


            //creating username of logged in user for added by
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            p.added_by = usr.id;

            //create a bool variable to check if the product is updated or not
             bool success=pdal.Update(p);   

            //if the product is updated successfully get the value of success will be true else it will be false
            if (success==true)
            {
                //product updated successfully
                MessageBox.Show("Product successfullt updated.");
                Clear();

                //refresh the data grid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                //failed to update product
                MessageBox.Show("Failed to update product.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the id of the product to be deleted
            p.id=int.Parse(txtID.Text);
            

            //create bool variable to check if the product is deleted or not
            bool success=pdal.Delete(p);

            //if product is deleted successfully then the value of success will be true else it will false
            if (success==true)
            {
                //product successfully deleted
                MessageBox.Show("Product successfully deleted.");
                Clear();

                //refreshing data grid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }
            else
            {
                //failed to delete producr
                MessageBox.Show("Failed to delete product.");
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keywords from form
            string keywords = txtSearch.Text ;

            if (keywords!=null)
            {
                //search the products
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource= dt;
            }
            else
            {
                //display all the products
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;
            }

        }
    }
}
