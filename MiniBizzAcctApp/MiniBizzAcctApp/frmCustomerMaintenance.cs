using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MiniBizzAcctApp
{
    public partial class frmCustomerMaintenance : Form
    {
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void customerMaintenanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerMaintenanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bakayMiniBizzDataSet);

        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.CustomerMaintenance' table. You can move, or remove it, as needed.
            this.customerMaintenanceTableAdapter.Fill(this.bakayMiniBizzDataSet.CustomerMaintenance);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerCode.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                

                string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                string cmdString = "INSERT INTO CustomerMaintenance ( CustomerCode, Name, Address, PhoneNumber) VALUES('" + txtCustomerCode.Text+"','"+ txtName.Text+"', '"+ txtAddress.Text+"', '"+ txtPhoneNumber.Text+"')";
                SqlCommand sqlCmd = new SqlCommand(cmdString, conn);
                int rows = sqlCmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    MessageBox.Show("Customer Information Added Successfully.");
                    txtCustomerCode.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtPhoneNumber.Text = "";

                }
                else
                {
                    MessageBox.Show("Error adding customer data. Please input correct data");
                }
                conn.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Date must be in this format - XXX-XXX-XXXX");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                string cmdString = "SELECT * FROM CustomerMaintenance WHERE CustomerCode ='" + txtCustomerCode.Text + "'";


                SqlCommand sqlCmd = new SqlCommand(cmdString, conn);
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCustomerCode.Text = dr.GetString(0);
                    txtName.Text = dr.GetString(1);
                    txtAddress.Text = dr.GetString(2);
                    txtPhoneNumber.Text = dr.GetString(3);
                }
                else
                {
                    MessageBox.Show("No Record Found with given code.");
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("CustomerCode is invalid");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string str = "DELETE FROM CustomerMaintenance WHERE CustomerCode = '" + txtCustomerCode.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(str, con);

            int rows = sqlCmd.ExecuteNonQuery();

            if (rows > 0)
            {
                MessageBox.Show(rows + " customer deleted");
                txtCustomerCode.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";

            }
            else
            {
                MessageBox.Show("No customer record found with given code");
            }

            con.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();


                string updatecmdString = "UPDATE CustomerMaintenance SET CustomerCode='" + txtCustomerCode.Text + "', CustomerCode='" + txtCustomerCode.Text + "', Name='" + txtName.Text + "', Address='" + txtAddress.Text + "', PhoneNumber='" + txtPhoneNumber.Text + "' WHERE CustomerID='" + txtCustomerCode.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(updatecmdString, conn);

                int rows = 4;//number of rows 
                if (rows > 0)
                {
                    MessageBox.Show("Update Successful.");
                    txtCustomerCode.Text = "";
                    txtName.Text = "";
                    txtAddress.Text = "";
                    txtPhoneNumber.Text = "";
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
                conn.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("CustomerID is invalid");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
