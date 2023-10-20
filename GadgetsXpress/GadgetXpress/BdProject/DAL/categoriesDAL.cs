using BdProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdProject.DAL
{
    internal class categoriesDAL
    {
        //static string method for database connection string
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select method 
        public DataTable select()
        {
            //connection database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                //writing sql querry to get all the data from database
                string sql = "SELECT * FROM tbl_categories";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                //open database connection
                conn.Open();

                //adding value from adapter to data table dt
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return dt;
        }
        #endregion
        #region insert new category
        public bool Insert(categoriesBLL c)
        {
            //creating a boolean variable and set its default value to false
            bool isSuccess = false;

            //connecting to database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //writing querry to add new category
                string sql = "INSERT INTO tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by) ";

                //creating sqql cmmand to pass values in our querry
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values through parameters
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

                //open databse connection
                conn.Open();

                //creating the int variable to execute the querry
                int rows = cmd.ExecuteNonQuery();

                //if the querry is executed successfully then its value will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //querry executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to execute querry
                    isSuccess=false;
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
        #region update method 
        public bool Update(categoriesBLL c)
        {
            //creating bool variable and set its default value to false
            bool isSuccess = false;

            //creating sql connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //query to update category 
                string sql = "UPDATE tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //sql command to pass the value on sql querry
                SqlCommand cmd = new SqlCommand (sql, conn);

                //passing value using cmd
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                //open database connection
                conn.Open();

                //create int variable  to execute querry 
                int rows = cmd.ExecuteNonQuery ();

                //if the querry is successfully executed then the value will be greater than 0
                if (rows > 0)
                {
                    //querry executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to execute querry
                    isSuccess=false;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally 
            {
                conn.Close(); 
            }



            return isSuccess;
        }

        #endregion
        #region delete category method
        public bool Delete(categoriesBLL c)
        {
            //create a bool variable and set its value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql querry to delete  from database
                string sql = "DELETE FROM tbl_categories WHERE id=@id";


                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing the value using cmd
                cmd.Parameters.AddWithValue("@id",c.id);

                //open sql connection
                conn.Open (); 
                
                int rows = cmd.ExecuteNonQuery ();


                //if the querry is successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0) 
                {
                    //querry executed successfully
                    isSuccess = true;
                }
                else
                {
                    //querry failed
                    isSuccess=false;
                }

            }
            catch(Exception ex) 
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
        #region method for search functionality
        public DataTable Search(string keywords)
        {
            //sql connection for database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //creating data table to hold the data from database temporary
            DataTable dt = new DataTable();
            
            try
            {
                //sql querry to search categories from database
                string sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR DESCRIPTION LIKE '" + keywords + "'";
                //creating sql command to execute the querry
                SqlCommand cmd = new SqlCommand (sql, conn);

                //creting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open ();


                //passing values from adapter to data table dt
                adapter.Fill (dt);
            }

            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conn.Close(); 
            }

            return dt;

        }

        #endregion
    }
}
