using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MiniBizzAcctApp
{
    public partial class frmInventoryMaintenance : Form
    {
        public frmInventoryMaintenance()
        {
            InitializeComponent();
        }

        private void inventoryMaintenanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventoryMaintenanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bakayMiniBizzDataSet);

        }

        private void frmInventoryMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.InventoryMaintenance' table. You can move, or remove it, as needed.
            this.inventoryMaintenanceTableAdapter.Fill(this.bakayMiniBizzDataSet.InventoryMaintenance);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string cmdString = "INSERT INTO InventoryMaintenance (ProductCode, ProductionDescription, QuantityOnHand, PurchasePrice, UnitPrice) VALUES('"+ txtProductCode.Text +"','"+txtProductDescription.Text + "', '"+txtQuantityOnHand.Text +"', '" +txtPurchasePrice.Text + "', '" + txtUnitPrice.Text +"')";
            SqlCommand sqlCmd = new SqlCommand(cmdString, conn);

            int rows = sqlCmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Customer Information Added Successfully.");
                txtProductCode.Text = "";
                txtProductDescription.Text = "";
                txtQuantityOnHand.Text = "";
                txtPurchasePrice.Text = "";
                txtUnitPrice.Text = "";

            }
            else
            {
                MessageBox.Show("Error adding customer data. Please input correct data");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();


                string updatecmdString = "UPDATE InventoryMaintenance SET ProductionDescription='" + txtProductDescription.Text + "', QuantityOnHand=" + txtQuantityOnHand.Text + ", PurchasePrice=" + txtPurchasePrice.Text + ", UnitPrice=" + txtUnitPrice.Text + " WHERE ProductCode='" + txtProductCode.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(updatecmdString, conn);

                int rows = sqlCmd.ExecuteNonQuery();//number of rows 
                if (rows > 0)
                {
                    MessageBox.Show("Product Information updated Successfully.");
                    txtProductCode.Text = "";
                    txtProductDescription.Text = "";
                    txtQuantityOnHand.Text = "";
                    txtPurchasePrice.Text = "";
                    txtUnitPrice.Text = "";


                }
                else
                {
                    MessageBox.Show("Update failed");
                }

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                string cmdString = "SELECT * FROM InventoryMaintenance WHERE ProductCode ='" + txtProductCode.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(cmdString, conn);
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                {
                    txtProductCode.Text = dr.GetString(0);
                    txtProductDescription.Text = dr.GetString(1);
                    //txtQuantityOnHand = Int32.Parse(dr.GetString(2));
                    txtQuantityOnHand.Text = dr.GetInt32(2).ToString();
                    txtPurchasePrice.Text = dr.GetDecimal(3).ToString();
                    txtUnitPrice.Text = dr.GetDecimal(4).ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found with given Id.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ProductCode is invalid");
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProductCode.Text = "";
            txtProductDescription.Text = "";
            txtQuantityOnHand.Text = "";
            txtPurchasePrice.Text = "";
            txtUnitPrice.Text = "";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
            SqlConnection con = new SqlConnection(connString);
            con.Open();

            string str = "DELETE FROM InventoryMaintenance WHERE ProductCode = '" + txtProductCode.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(str, con);

            int rows = sqlCmd.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show(rows + " product deleted");
                txtProductCode.Text = "";
                txtProductDescription.Text = "";
                txtQuantityOnHand.Text = "";
                txtPurchasePrice.Text = "";
                txtUnitPrice.Text = "";

            }
            else
            {
                MessageBox.Show("No product record found with given code");
            }
            con.Close();

        }
    }
}
