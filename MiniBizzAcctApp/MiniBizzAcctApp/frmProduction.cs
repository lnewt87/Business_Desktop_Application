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
    public partial class frmProduction : Form
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Excel.exe");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string ConnString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection SqlConn = new SqlConnection(ConnString);
                SqlConn.Open();

                string CmdString = "INSERT INTO SalesProduction (ProductCode, CustomerID, CustomerName, SaleDate, ProductionDescription, Quantity, SalesPrice, TotalSalesPrice) VALUES ('" + txtProductCode.Text + "', '" + txtCustomerID.Text + "','" + cboCustomerName.Text + "', '" + DateTimePickerProduction.Text + "', '" + cboProductDescription.Text + "', '" + txtQuantity.Text + ", " + txtSalesPrice.Text + ", " + txtTotalSalesPrice.Text + ")";

                SqlCommand SqlCmd = new SqlCommand(CmdString, SqlConn);
                int row = 8;

                

                if (row > 0)
                {
                    MessageBox.Show("Data Saved successfully");
                    txtQuantity.Text = "";
                    txtSalesPrice.Text = "";
                    txtTotalSalesPrice.Text = "";

                }
                else
                {

                    MessageBox.Show("Check your input.");

                }
           
            }
                catch (Exception) {
                MessageBox.Show("An input is not Jelling well");


            }

           
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
       
        
            try
            {
                Decimal Quantity = Decimal.Parse(txtQuantity.Text);
                Decimal SalesPrice = Decimal.Parse(txtSalesPrice.Text);
                Decimal TotalSalesPrice = Quantity * SalesPrice;

                if (Quantity > 0)
                {
                    if (SalesPrice > 0)
                    {
                        txtTotalSalesPrice.Text = Convert.ToString(TotalSalesPrice);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Total Sales Entered");
            }

        }

        private void frmSalesProduction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.SalesProduction' table. You can move, or remove it, as needed.
            this.salesProductionTableAdapter.Fill(this.bakayMiniBizzDataSet.SalesProduction);
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.CustomerMaintenance' table. You can move, or remove it, as needed.
            this.customerMaintenanceTableAdapter.Fill(this.bakayMiniBizzDataSet.CustomerMaintenance);
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.InventoryMaintenance' table. You can move, or remove it, as needed.
            this.inventoryMaintenanceTableAdapter.Fill(this.bakayMiniBizzDataSet.InventoryMaintenance);

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

