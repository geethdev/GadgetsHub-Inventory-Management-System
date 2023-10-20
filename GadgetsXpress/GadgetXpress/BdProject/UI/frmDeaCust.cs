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
    public partial class frmDeaCust : Form
    {
        public frmDeaCust()
        {
            InitializeComponent();
        }

        private void frmDeaCust_Load(object sender, EventArgs e)
        {

            //refreshing data grid view
            DataTable dt = dcDal.Select();
            dgvDeaCust.DataSource = dt;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //code to close this form
            this.Hide();
        }

        DeaCustBLL dc = new DeaCustBLL();
        DeaCustDAL dcDal = new DeaCustDAL();

        userDAL uDal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the values from form
            dc.type = cmbDeaCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            //getting the id to logged in user and passing its values in dealer or customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            //creating bool variable to check weather thre dealer or customer is added or not
            bool success = dcDal.Insert(dc);

            if (success==true)
            {
                //dealer or customer inserted successfully
                MessageBox.Show("Dealer or Customer added successfully");
                Clear();

                //refreshing data grid view
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt; 


            }
            else
            {
                //failed to insert dealer or cust

            }

        } 
        public void Clear()
        {
            txtDeaCustID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void dgvDeaCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //int variable to create a identity row clicked
            int rowIndex = e.RowIndex;

            txtDeaCustID.Text = dgvDeaCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDeaCust.Text = dgvDeaCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDeaCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDeaCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDeaCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDeaCust.Rows[rowIndex].Cells[5].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the values from form
            dc.id = int.Parse(txtDeaCustID.Text);
            dc.name = txtName.Text;
            dc.type=cmbDeaCust.Text;
            dc.email=txtEmail.Text;
            dc.contact=txtAddress.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;

            //getting the id to logged in user and passing its values in dealer or customer module
            string loggedUsr = frmLogin.loggedIn;
            userBLL usr = uDal.GetIDFromUsername(loggedUsr);
            dc.added_by = usr.id;

            //create bool variable to ckeck weather the dealer or customer is updated or not
            bool success = dcDal.Update(dc);    

            if (success == true )
            {
                //dealer and customer updated successfully
                MessageBox.Show("Dealer or Customer updated successfully.");
                Clear();

                //refresh the data grid view
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource= dt;

            }

            else
            {
                //failed to update dealer or customer
                MessageBox.Show("Failed to update Dealer or Customer.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the id of the user to be deleted from form
            dc.id = int.Parse(txtDeaCustID.Text);

            //create bool variable to check wheather the dealer or customer is deleted or not
            bool success = dcDal.Delete(dc);    

            if (success == true )
            {
                //dealer ofr customer deleted successfully
                MessageBox.Show("Dealer or Customer deleted successfully.");
                Clear();

                //refresh the data grid view
                DataTable dt = dcDal.Select();
                dgvDeaCust.DataSource = dt;
            }
            else
            {
                //dealer or customer failed to delete
                MessageBox.Show("Failed to delete Dealer or Customer.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from textbox
            string keyword = txtSearch.Text;

            if (keyword !=null )
            {
                //search the dealer or customer
                DataTable dt = dcDal.Search(keyword);
                dgvDeaCust.DataSource=dt;
            }
            else
            {
                //show all the dealer or customer
                DataTable dt=dcDal.Search(keyword);
                dgvDeaCust.DataSource = dt;
            }
        }

        
    }
}
