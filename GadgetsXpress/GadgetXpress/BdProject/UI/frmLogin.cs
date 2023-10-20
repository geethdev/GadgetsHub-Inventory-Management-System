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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void pboxClose_Click(object sender, EventArgs e)
        {
            //code to close this form
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //checking login credentials
            bool success = dal.loginCheck(l);   
            if (success==true)
            {
                //login successfull
                // MessageBox.Show("Login successfull");
                loggedIn = l.username;

                //need to open respective form based on user type
                switch(l.user_type)
                {
                    case "Admin":
                        {
                            //display admin dashboard
                            frmAdminDashBoard admin = new frmAdminDashBoard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //display user dashbard
                            frmuUserDashboard user = new frmuUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //display an error message
                            MessageBox.Show("Invalid user type");
                        }
                        break;

                }
            }
            else
            {
                //login fail
                MessageBox.Show("Login failed. Try again.");
            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblSHead_Click(object sender, EventArgs e)
        {

        }

        private void lblFappName_Click(object sender, EventArgs e)
        {

        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserType_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relax and try to remind your password", "Forget your password?");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //checking login credentials
            bool success = dal.loginCheck(l);
            if (success == true)
            {
                //login successfull
                MessageBox.Show("Login successfull");
                loggedIn = l.username;

                //need to open respective form based on user type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //display admin dashboard
                            frmAdminDashBoard admin = new frmAdminDashBoard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //display user dashbard
                            frmuUserDashboard user = new frmuUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //display an error message
                            MessageBox.Show("Invalid user type");
                        }
                        break;

                }
            }
            else
            {
                //login fail
                MessageBox.Show("Login failed. Try again.");
            }

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //checking login credentials
            bool success = dal.loginCheck(l);
            if (success == true)
            {
                //login successfull
                // MessageBox.Show("Login successfull");
                loggedIn = l.username;

                //need to open respective form based on user type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //display admin dashboard
                            frmAdminDashBoard admin = new frmAdminDashBoard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //display user dashbard
                            frmuUserDashboard user = new frmuUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //display an error message
                            MessageBox.Show("Invalid user type");
                        }
                        break;

                }
            }
            else
            {
                //login fail
                MessageBox.Show("Login failed. Try again.");
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //checking login credentials
            bool success = dal.loginCheck(l);
            if (success == true)
            {
                //login successfull
                // MessageBox.Show("Login successfull");
                loggedIn = l.username;

                //need to open respective form based on user type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //display admin dashboard
                            frmAdminDashBoard admin = new frmAdminDashBoard();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //display user dashbard
                            frmuUserDashboard user = new frmuUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //display an error message
                            MessageBox.Show("Invalid user type");
                        }
                        break;

                }
            }
            else
            {
                //login fail
                MessageBox.Show("Login failed. Try again.");
            }
        }

        private void pboxClose_Click_1(object sender, EventArgs e)
        {
            //code to close this form
            this.Close();
        }
    }
}
