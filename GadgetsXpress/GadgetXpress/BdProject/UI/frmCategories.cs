using BdProject.BLL;
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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        userDAL udal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the value from category form
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            //getting id in added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            //passing the id of logeed in user in added by field
            c.added_by = usr.id;

            //creating method to insert data into database
            bool success = dal.Insert(c);

            //if the category is inserted successfully then the value of the success will be true else it will be false
            if (success)
            {
                //new category inserted successfully
                MessageBox.Show("New category inserted successfully.");
                Clear();

                //refresh data grid view
                DataTable dt = dal.select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                //failed to insert 
                MessageBox.Show("Failed to insert new category.");
            }
        }

        public void Clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            //here write the code to desplay all the categories in data grid view
            DataTable dt = dal.select();
            dgvCategories.DataSource = dt;
        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //finding the row index of the row clicked in data grid view
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the values from the categories form
            c.id=int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text ;
            c.added_date = DateTime.Now;
            //getting id in added by field
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = udal.GetIDFromUsername(loggedUser);
            //passing the id of logeed in user in added by field
            c.added_by = usr.id;

            //creating variable to update categories
            bool success = dal.Update(c);
            //if the category is updated successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //category updated successully
                MessageBox.Show("Category updated successfully");
                Clear();
                //refresh data grid view
                DataTable dt = dal.select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                //failed to update category
                MessageBox.Show("Failed to update category");
            }
        } 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the id of the gategory wich we want to delete
            c.id=int.Parse(txtCategoryID.Text);

            //createing boolean variable to delete a gategory
            bool success = dal.Delete(c);

            //if the category is deleted successfully then the value of success will be true else it will be false
            if(success == true)
            {
                //category deleted successfully
                MessageBox.Show("Category deleted successfully.");
                Clear();
                //refreshing datagrid view
                DataTable dt = dal.select();
                dgvCategories.DataSource = dt;

            }
            else
            {
                //failed to delete category
                MessageBox.Show("Failed to delete category");
            }
        } 

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keywords
            string keywords=txtSearch.Text;

            //filter the categories based on keywords
            if (keywords!=null)
            {
                //use search method to desplay categories
                DataTable dt = dal.Search(keywords);
                dgvCategories.DataSource=dt;

            }
            else
            {
                //use select method to desplay all categories
                DataTable dt = dal.select();
                dgvCategories.DataSource = dt;


            }
        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCategoryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategories_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //finding the row index of the row clicked in data grid view
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
        }
    }
}
