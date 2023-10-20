using BdProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BdProject.DAL
{
    internal class productsDAL
    {
        //creating static string method for db connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region select method for product module
        public DataTable Select()
        {
            //create sql connection to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //datatable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //writing the querry to select all the products from database
                string sql = "SELECT * FROM tbl_products";

                //crerating sql command to execute querry
                SqlCommand cmd = new SqlCommand(sql, conn);

                //sql data adapter to hold the value from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.Message");
            }
            finally 
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region method to insert product in database
        public bool Insert(productsBLL p)
        {
            //creating bool variable and set its default value to false
            bool isSuccess = false;

            //sql connection for databse
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //sql querry to insert product into databse
                string sql = "INSERT INTO tbl_products (name, category, description, rate, qty, added_date, added_by) VALUES (@name, @category, @description, @rate, @qty, @added_date, @added_by)";

                //CREATE SQL COMMAND TO PASS THE VALUE
                SqlCommand cmd = new SqlCommand(sql, conn);


                //parsing the values yjrough parameters
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                //openning the databse connection
                conn.Open();

                int rows=cmd.ExecuteNonQuery();

                //if the querry is exeuted successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //querry executed sccessfully
                    isSuccess = true;
                }
                else
                {
                    //querry failled
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
        #region method to update product in database
        public bool Update (productsBLL p)
        {
            //create a bool variable and set its value to false
            bool isSuccess = false;

            //create sql connection for database'
            SqlConnection conn= new SqlConnection(myconnstrng);

            try
            {
                //sql querry to update data in database
                string sql = "UPDATE tbl_products SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //crete sql command to pass the value to querry
                SqlCommand cmd= new SqlCommand(sql, conn);

                //passing values using parameters
                cmd.Parameters.AddWithValue("@name",p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);


                //open database connection
                conn.Open();

                //create int variable to check if the querry is executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //if the querry is executed successfully then the value of rows will be grater than 0 else it will be less than 0
                if (rows > 0)
                {
                    //querry executed successfully
                    isSuccess = true;
                }
               else 
                {
                    //failed to execute
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
        #region method to delete product from databse
        public bool Delete(productsBLL p)
        {
            //create bool variable and set its value to false
            bool isSuccess = false;

            //sql connection for database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //write query to product from databse
                string sql = "DELETE FROM tbl_products WHERE id=@id";

                //sql command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value using cmd
                cmd.Parameters.AddWithValue("@id", p.id);


                //open the database connection
                conn.Open() ;

                int rows = cmd.ExecuteNonQuery();

                //if the querry is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                if(rows > 0)
                {
                    //querry executed successfully
                    isSuccess = true;
                }
                else
                {
                    //querry failled
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
        #region search method for product module
        public DataTable Search(string keywords)
        {
            //sql connection for db connesctio
            SqlConnection conn =new SqlConnection(myconnstrng);

            //creating datatable to hold the value from database
            DataTable dt = new DataTable();

            try
            {
                //sql querry to search product 
                string sql = "SELECT * FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";
                
                //sql command to execute querry
                SqlCommand cmd = new SqlCommand(sql, conn);
                
                //sql data adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open the database connection
                conn.Open();

                adapter.Fill(dt);

            }
            catch(Exception ex)
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
        #region method to search product in transaction module
        public productsBLL getProductsForTransaction(string keywords)
        {
            //create an object of productBLL and return it
            productsBLL p = new productsBLL();

            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //datatable to store data temporarily
            DataTable dt = new DataTable();

            try
            {
                //write the query to get the details
                string sql = "SELECT name, rate, qty FROM tbl_products WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'";

                //CREATE SQL DATADAPTER TO EXECUTE THE QUERRY
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //open database connection
                conn.Open();

                //pass the value from adapter to dt
                adapter.Fill(dt);

                //if we have any value on dt set the values to productBLL
                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString()); ;
                   
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //close database connection
                conn.Close();
            }
            
            return p;
        }
        #endregion
        #region method to get product id basd on product name
        public productsBLL GetDeaProductIDFromName(string productName)
        {
            //first create an object of deaCustBLL and return it
            productsBLL p=new productsBLL();

            //sql connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            //datatable to holde the data temporarily
            DataTable dt = new DataTable();

            try
            {
                //sql query to get id based on name
                string sql = "SELECT id FROM tbl_products WHERE name='" + productName + "'";

                //create the sql data adapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //open database connection
                conn.Open();

                //passing the value from adapter to datatable
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //pass the value from dt to DeaCustBll dc
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());

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

            return p;



        }

        #endregion
        #region method to get current qty from database based on product ID
        public decimal GetProductQty (int productID)
        {
            //sql connection first
            SqlConnection conn = new SqlConnection(myconnstrng) ;

            //create a decimal variable and set its value to 0
            decimal qty = 0;

            //create datatable to save the data from database temporarily
            DataTable dt = new DataTable(); 

            try
            {
                //write sql query to get quantity from database
                string sql = "SELECT qty FROM tbl_products WHERE id=" + productID;

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql dataadapter to execuute the query
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open db connection
                conn.Open();

                //pass the value from data adapter to data table
                adapter.Fill(dt);

                //lets check if the datatable has the value or not
                if(dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["qty"].ToString());
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                //close db connection
                conn.Close(); 
            }
            return qty;
         
        }
        #endregion
        #region method to update quantity 
        public bool UpdateQuantity(int productID, decimal Qty)
        {
            //create a bool variable and set its value to false
            bool success = false;

            //sql connection to connect database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //write sql query to update quantity
                string sql = "UPDATE tbl_products SET qty=@Qty WHERE id=@id";

                //create sql command to pass  the value into query
                SqlCommand cmd = new SqlCommand (sql, conn);

                //passing value through parameters
              
                cmd.Parameters.AddWithValue("qty", Qty);
                cmd.Parameters.AddWithValue("id", productID);
                
                //open database connection
                conn.Open();

                //create int variable and check if wheather query executed successfully or not
                int rows = cmd.ExecuteNonQuery();

                //lets check if the query is executed successfully or not
                if (rows > 0)
                {
                    //query executed successfully
                    success = true;
                }
                else 
                {
                    //query execute failed
                    success = false; 
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


            return success;
        }
        #endregion
        #region method to increase product
        public bool IncreaseProduct(int productID, decimal Increaseqty) 
        {
            //create a bool variable and set its value to false
            bool success = false;

            //create sql connection to connect db
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //get the current quantity from database and id
                decimal currentQty = GetProductQty(productID);

                //increase the currents quantity by the qty purchased from dealer
                decimal NewQty = currentQty * Increaseqty;

                //update the product quantity now
                success = UpdateQuantity(productID, NewQty);
            }
            catch ( Exception ex) 
            {
                MessageBox.Show (ex.Message);   
            }
            finally
            {
                conn.Close();
            }

            return success;
        }

        #endregion
        #region method to decrease product
        public bool DecreaseProduct(int productID, decimal Qty)
        {
            //create a bool variable and set its value to false
            bool success = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //get the current product quantity
                decimal CurrentQty = GetProductQty(productID);

                //decrease the product quantity based on product sales
                decimal NewQty = CurrentQty - Qty;

                //update the product in database
                success = UpdateQuantity(productID, NewQty);

            }
            catch( Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
            finally
            { 
                conn.Close(); 
            }

            return success;
        }

        #endregion
        #region display products based on categories
        public DataTable DisplayProductByCategory (string category)
        {
            //sql connection first
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query to display product base on category
                string sql = "SELECT * FROM tbl_products WHERE category ='" + category + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open db connection
                conn.Open();

                adapter.Fill(dt);

            }
            catch ( Exception ex )
            {
                MessageBox.Show (ex.Message);
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
