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
using System.Transactions;
using System.Windows.Forms;

namespace BdProject.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DeaCustDAL dcDal = new DeaCustDAL();
        productsDAL pDAL = new productsDAL();
        userDAL userDAL = new userDAL();
        transactionDALL tDAL = new transactionDALL();
        transactionDetailDAL tdDAL = new transactionDetailDAL();

        DataTable transactionDT = new DataTable();
        

        private void frmPurAndSales_Load(object sender, EventArgs e)
        {
            //get the transaction type value from user dashboard
            string type = frmuUserDashboard.transactionType;

            //set the value on lblTop
            lblTop.Text = type;

            //specify columns for our transaction data table
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from the text box
            string keywords = txtSearch.Text;
            
            if (keywords =="")
            {
                //clear the textboxes
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;

            }

            //write the code to get the details and set the values on text boxes
            DeaCustBLL dc = dcDal.searchDealerCustomerForTransaction(keywords);

            //now transfer or set the value from DeaCustBLL to textboxes
            txtName.Text=dc.name;
            txtEmail.Text=dc.email;
            txtContact.Text=dc.contact;
            txtAddress.Text=dc.address;

            
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            //get the keyword from product search text box
            string keywords = txtSearchProduct.Text;

            //check  if we hAVE value on txtsearchProduct or not
            if(keywords == "")
            {
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtQty.Text = "";
                txtRate.Text = "";
                return;
            }

            //search the product and display on respective text boxes
            productsBLL p=pDAL.getProductsForTransaction(keywords);


            //set the values on textboxes based on the object
            txtProductName.Text=p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //get the product name , rate , qty customer wants to buy
            string productName = txtProductName.Text;
            decimal rate = decimal.Parse(txtRate.Text);
            decimal qty = decimal.Parse(txtQty.Text);

            //total = rate* qty
            decimal total = rate * qty;

            //display the subtotal in text box
            //get the  subtotal value from textbox
            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + total;


            //check whether the product is selected or not
            if (productName =="")
            {
                //display error msg
                MessageBox.Show("Select the product first. Try again.");
            }
            else
            {
                //add product to data grid view
                transactionDT.Rows.Add(productName, rate, qty,total);

                //show in datagrid view
                dgvAddedProducts.DataSource = transactionDT;

                //display the subtotal in text box
                txtSubTotal.Text = subTotal.ToString();

                //clear the text boxes
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQty.Text = "";


            }

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //get the value from discount text box
            string value = txtDiscount.Text;
            if (value == "")
            {
                //display error msg
                MessageBox.Show("Please add discount first.");
            }
            else
            {
                //get the discount in decimal value
                decimal discount = decimal.Parse(txtDiscount.Text);
                decimal subTotal = decimal.Parse(txtSubTotal.Text);

                //calculate the grand total based on discount
                decimal grandTotal = ((100 - discount)/100)*subTotal;

                //display the grand total in text box
                txtGrandtotal.Text = grandTotal.ToString();

            }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            //check the grandTotal has value or not if it has not value then calculate discont first
            string check = txtGrandtotal.Text;
            if(check == "")
            {
                //display the error msg to calculate discount
                MessageBox.Show("Calculate the discount and set the grand total first.");
            }
            else
            {
                //calculate vat
                //getting the VAT percent first
                decimal previousGT = decimal.Parse(txtGrandtotal.Text);
                decimal vat = decimal.Parse(txtVat.Text);
                decimal grandTotalWithVAT = ((100 + vat)/100)*previousGT;

                //displaying new grand total with VAT
                txtGrandtotal.Text = grandTotalWithVAT.ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            //get the paid amount and grand total
            decimal grandTotal = decimal.Parse(txtGrandtotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            //display the return amount as well
            txtReturnAmount.Text = returnAmount.ToString();


        }

        private void lblcalculationTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //get the values from purchaseSales form first
            transactionsBLL transaction = new transactionsBLL();

            transaction.type = lblTop.Text;

            //get the id of deler or customer here
            //lets get name of the dealer or customer first
            string deaCustName = txtName.Text;
            DeaCustBLL dc = dcDal.GetDeaCustIDFromNAme(deaCustName);

            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtGrandtotal.Text), 2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = decimal.Parse(txtVat.Text);   
            transaction.discount = decimal.Parse(txtDiscount.Text);


            //get the username of logged in user
            string username = frmLogin.loggedIn;
            userBLL u = userDAL.GetIDFromUsername(username);

            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            //lets create a bool variable and set its value to false
            bool success = false;

            //actual code to insert transaction and transaction details
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;

                //create an bool value and insert transaction
                bool w = tDAL.Insert_transaction(transaction, out transactionID);

                //use for loop to insert transaction details
                for(int i = 0;i< transactionDT.Rows.Count;i++)
                {
                    //get all the details of the products
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();

                    //get the product name and convert it to id
                    string productName = transactionDT.Rows[i][0].ToString();
                    productsBLL p = pDAL.GetDeaProductIDFromName(productName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = u.id;

                    //here increase or decrease product quantity based on purchase or sales
                    string transactionType = lblTop.Text;

                    //lets check whether we are on purchase or sales
                    bool x = false;
                    if (transactionType =="Purchase")
                    {
                        //increase the product
                         x = pDAL.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);

                    }
                    else if (transactionType =="Sales")
                    {
                        //decrease the product quantity
                         x = pDAL.DecreaseProduct(transactionDetail.product_id,transactionDetail.qty);
                    }



                    //insert transaction details insert the database
                    bool y =tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && x && y;


                }
                
                if (success == true)
                {
                    //transaction complete
                    scope.Complete();
                    MessageBox.Show("Transaction completed successfully");

                    //clear the datagrid view and clear all text boxes
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();

                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtSearchProduct.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQty.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtVat.Text = "0";
                    txtGrandtotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";

                }
                else
                {
                    //transaction failled
                    MessageBox.Show("Transaction failed");
                }

            }

        }

        private void pnlCalculation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAddedProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
