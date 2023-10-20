using BdProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BdProject.DAL
{
    internal class userDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select data from database
        public DataTable Select()
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //to hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //sql querry to get data from database
                string sql = "SELECT * FROM tbl_users";

                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //database connection open
                conn.Open();

                //fill data in our datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //throww messege if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //closing sonnection
                conn.Close();
            }

            //return the value in datatable
            return dt;
        }
        #endregion
        #region insert data in databse

        public bool Insert(userBLL u)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_users  (first_name, last_name, email, username, password, contact, address, gender, user_type, added_date, added_by) VALUES (@first_name, @last_name, @email, @username, @password, @contact, @address, @gender, @user_type, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the querry is executed successfully the value to rows will be greater than 0 else it iwll be less than 0

                if (rows > 0)
                {
                    //querry successfull
                    isSucess = true;
                }
                else
                {
                    //querry fail
                    isSucess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;
        }
        #endregion
        #region update data indatabase
        public bool Update(userBLL u)
        {
            bool isSucess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_users SET first_name=@first_name, last_name=@last_name, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, user_type=@user_type, added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //querry success
                    isSucess = true;
                }
                else
                {
                    //querry fail
                    isSucess= false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;
        }
        #endregion
        #region delete data from database
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM tbl_users WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //querry successfull
                    isSuccess = true;
                }
                else
                {
                    //querry faill
                    isSuccess = false;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        #endregion
        #region search user on database using keyword
        public DataTable Search(string keywords)
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            //to hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //sql querry to get data from database
                string sql = "SELECT * FROM tbl_users WHERE id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "%' OR last_name LIKE '%" + keywords + "%' OR usernanme LIKE '%" + keywords + "%'" ;

                //for executing command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //database connection open
                conn.Open();

                //fill data in our datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //throw messege if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //closing sonnection
                conn.Close();
            }

            //return the value in datatable
            return dt;
        }
        #endregion
        #region getting user id from user name
        public userBLL GetIDFromUsername (string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id FROM tbl_users WHERE username='" + username + "'";

                SqlDataAdapter adapter = new SqlDataAdapter (sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());
                    

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                
            }
            finally 
            {
                conn.Close(); 
            }
            return u;
        }
        #endregion
    }
}
