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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            //getting data from UI
            u.first_name = txtFirstname.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUsertype.Text;
            u.added_date = DateTime.Now;

            //geting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);

            u.added_by = usr.id;

            //inserting data into database
            bool success = dal.Insert(u);

            //if the data successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //data successfully inserted
                MessageBox.Show("User successfully created.");
                clear();
            }
            else
            {
                //failed to connect
                MessageBox.Show("Failed to add new user.");
            }
            //refreshing data grid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;


        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }
        private void clear()
        {
            txtUserID.Text = "";
            txtFirstname.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUsertype.Text = "";

        }

        private void dgvUsers_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        {


        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get index of perticuler row
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUsertype.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the value from user UI
            u.id = Convert.ToInt32(txtUserID.Text);
            u.first_name = txtFirstname.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUsertype.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;


            //updating data into database
            bool success = dal.Update(u);

            //if data is not inserted successfully then the value of success will be true else it will be false
            if (success == true)
            {
                //data updated successfully
                MessageBox.Show("User successfully updated.");
                clear();
            }
            else
            {
                //failed to update user
                MessageBox.Show("Failed to update user");
            }
            //refreshing data grid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //getting user id from form
            u.id = Convert.ToInt32(txtUserID.Text);

            bool success = dal.Delete(u);

            //if data is deleted then the value of success will be true else it will be false
            if (success == true)
            {
                //user deleted successfully
                MessageBox.Show("User deleted successfully");
                clear();
            }
            else
            {
                //failed to delete user
                MessageBox.Show("Failed to delete user");

            }
            //refreshing datagrid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from text box
            string keywords = txtSearch.Text;

            //check if the keyword has value or not
            if (keywords == null)
            {
                //show user based on keywords
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //show all users from the database
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;

            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {



            //getting data from UI
            u.first_name = txtFirstname.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUsertype.Text;
            u.added_date = DateTime.Now;

            //geting username of logged in user
            string loggedUser = frmLogin.loggedIn;
            userBLL usr = dal.GetIDFromUsername(loggedUser);

            u.added_by = usr.id;

            //inserting data into database
            bool success = dal.Insert(u);

            //if the data successfully inserted then the value of success will be true else it will be false
            if (success == true)
            {
                //data successfully inserted
                MessageBox.Show("User successfully created.");
                clear();
            }
            else
            {
                //failed to connect
                MessageBox.Show("Failed to add new user.");
            }
            //refreshing data grid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void dgvUsers_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            //get index of perticuler row
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstname.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUsertype.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
        }
    }

}