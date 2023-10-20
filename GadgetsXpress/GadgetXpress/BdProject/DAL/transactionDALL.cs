using BdProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BdProject.DAL
{
    internal class transactionDALL
    {
        //create a connection string variable 
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert transaction method
        public bool Insert_transaction(transactionsBLL t, out int transactionID)
        {
            //create a bool value and set its default value to false
            bool isSuccess = false;

            //set the out transaction id value tp negative 1
            transactionID = -1;

            //create a sql connectiom first
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql query to insert transaction 
                string sql = "INSERT INTO tbl_transations (type, dea_cust_id, grandTotal, transaction_date, tax, discount, added_by) VALUES (@type, @dea_cust_id, @grandTotal, @transaction_date, @tax, @discount, @added_by);SELECT @@IDENTITY";

                //SQL COMMAND TO PASS THE VALUE IN SQL QUERY
                SqlCommand cmd = new SqlCommand(sql, conn);

                //PASSING THE VALUE TO SQL QUEY USING CMD
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                //open databse connection
                conn.Open();

                //execute the query
                object o = cmd.ExecuteScalar();

                //if the querry is executed successfully then the value will not be null else it will be null
                if (o != null)
                {
                    //query executed successfully
                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                    
                }
                else
                {
                    //querry execute failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                //close the connection
                conn.Close();
                
            }

            return isSuccess;

        }
        #endregion
        #region method to display all the transactions
        public DataTable DisplayAllTransactions()
        {
            //sql connection first
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create a datatable to hold the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //write the sql querry to display all transactions
                string sql = "SELECT * FROM tbl_transations";

                //sqlcommand to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //sql data adapter to hold the dtabase data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open databse connection
                conn.Open();

                adapter.Fill(dt);
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close ();
            }
            return dt;
        }


        #endregion
        #region method to display transaction based on transaction type
        public DataTable DisplayTransactionByType(string type)
        {
            //create sql cvonnection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //create datatable
            DataTable dt = new DataTable();

            try
            {
                //write sql query
                string sql = "SELECT * FROM tbl_transation WHERE type='" + type + "'";

                //sql command to execute query
                SqlCommand cmd= new SqlCommand(sql, conn);

                //create sql dataadapter to hold the data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                //open db connection
                conn.Open ();

                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                conn.Close (); 
            }


            return dt;
        }

        #endregion
    }
}
