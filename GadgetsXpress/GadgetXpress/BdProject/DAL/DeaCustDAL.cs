using BdProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdProject.DAL
{
    internal class DeaCustDAL
    {
        //static string method for database connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region select method for Dealer and customer
        public DataTable Select()
        {
            //sql connection for databse connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //datatable to hold the values from database and return it
            DataTable dt = new DataTable();

            try
            {
                //write sql querry to select all the data from database
                string sql = "SELECT * FROM tbl_dea_cust";

                //creating sql command to execute querry
                SqlCommand cmd = new SqlCommand(sql, conn);

                //creating sql data adapter to store data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                //passing the value from sql data adapter to data table
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
        #region insert method to add details of dealer and customer
        public bool Insert(DeaCustBLL dc)
        {
            //creating sql connection first
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create an bool value and set its default value to false
            bool isSuccess = false;

            try
            {
                //write sql querry to insert details of dealer or customer
                string sql = "INSERT INTO tbl_dea_cust (type, name, email, contact, address, added_date, added_by) VALUES (@type, @name, @email, @contact, @address, @added_date, @added_by)";

                //SQL COMMAND TO PASS THE VALUES TO QUERRY
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing the values using parameters
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

                //open databse connection
                conn.Open();

                //int variable to check whether the querry is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //if the querry is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //querry executed successfully
                    isSuccess = true;
                }

                else
                {
                    //query failed
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
        #region update method for dealer and customer module
        public bool Update(DeaCustBLL dc)
        {
            //sql connection for database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create bool variable and set its default value to false
            bool isSuccess = false;

            try
            {
                //sql suery to update data in database
                string sql = "UPDATE tbl_dea_cust SET type=@type, name=@name, email=@email, contact=@contact, address=@address, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //create sql command to pass the value in sql
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values through parameters
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

                //open database connection
                conn.Open();

                // int variable to check if the querry executed successfully or not
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    //query executed successfully
                    isSuccess = true;
                }

                else
                {
                    //failed to execute querry
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
        #region delete method for dealer and customer
        public bool Delete(DeaCustBLL dc)
        {
            //sql connection for database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create bool variable and set its default value to false
            bool isSuccess = false;

            try
            {
                //sql query to delete data from database'
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

                //sql command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value
                cmd.Parameters.AddWithValue("@id", dc.id);

                //open database connection
                conn.Open();

                //int variable 
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    //querry executed successfully
                    isSuccess = true;
                }
                else
                {
                    //failed to execute 
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
        #region search method for dealer and customer module
        public DataTable Search(string keyword)
        {
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //creating data table and returning its value
            DataTable dt = new DataTable();

            try
            {
                //query to search dealer or customer based id type and name
                string sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                //sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //sql data adapter to hold the data from database temporary
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                //pass the value from adapter to datatable
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
        #region method to search dealer or customer for transaction module
        public DeaCustBLL searchDealerCustomerForTransaction(string keywords)
        {
            //create a object for deaCustBLL class
            DeaCustBLL dc = new DeaCustBLL();

            //create a database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create a datatable to holde a vlue temperorily
            DataTable dt = new DataTable();



            try
            {
                //sql query to search dealer or customer based on keywords
                string sql = "SELECT name, email, contact, address FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR name LIKE'%" + keywords + "%' ";

                //CREATE A SQL DATAADAPTER TO EXECUTE THE QUERY
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //open the database connection
                conn.Open();

                //transfer the data from sql dataadpter to datatable
                adapter.Fill(dt);

                // if we have value on dt we need to save it in dealercustomer BLL
                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
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

            return dc;


            
        }
        #endregion
        #region method to get id of the dealer or customer based on name
        public DeaCustBLL GetDeaCustIDFromNAme(string name)
        {
            //first create an object of deaCustBLL and return it
            DeaCustBLL dc = new DeaCustBLL();

            //sql connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            //datatable to holde the data temporarily
            DataTable dt = new DataTable();

            try
            {
                //sql query to get id based on name
                string sql = "SELECT id FROM tbl_dea_cust WHERE name='" + name + "' ";

                //create the sql data adapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //open database connection
                conn.Open();

                //passing the value from adapter to datatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //pass the value from dt to DeaCustBll dc
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString()); 

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                //close the database connection
                conn.Close(); 
            }

            return dc;
            

            
        }

        #endregion
      
    }
}
