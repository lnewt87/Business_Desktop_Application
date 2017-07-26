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
using System.Diagnostics;

namespace MiniBizzAcctApp
{
    public partial class frmExpenseMaintenance : Form
    {
        public frmExpenseMaintenance()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmExpenseMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.SalesProduction' table. You can move, or remove it, as needed.
            this.salesProductionTableAdapter.Fill(this.bakayMiniBizzDataSet.SalesProduction);
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.InventoryMaintenance' table. You can move, or remove it, as needed.
            this.inventoryMaintenanceTableAdapter.Fill(this.bakayMiniBizzDataSet.InventoryMaintenance);
            // TODO: This line of code loads data into the 'bakayMiniBizzDataSet.ExpenseMaintenance' table. You can move, or remove it, as needed.
           // this.expenseMaintenanceTableAdapter.Fill(this.bakayMiniBizzDataSet.ExpenseMaintenance);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void expenseDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void expenseMaintenanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExpenseID.Text = "";
            txtExpenseDescription.Text = "";
            dateTimePickerExpenseDate.Text = "";
            txtExpenseAmount.Text = "";
            txtBusinessCapital.Text = "";
            txtGrandTotalProduct.Text = "";
            txtGrandTotalExpense.Text = "";
            txtGrandBusinessProfit.Text = "";




        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection SqlConn = new SqlConnection(ConnString);
                SqlConn.Open();

                string CmdString = "INSERT INTO ExpenseMaintenance ( ProductCode, ExpenseDescription, ExpenseDate, ExpenseAmount) VALUES( '" + cboProductCode.Text + "', '" + txtExpenseDescription.Text + "', '" + dateTimePickerExpenseDate.Text + "', '" + txtExpenseAmount.Text + "')";
                SqlCommand SqlCmd = new SqlCommand(CmdString, SqlConn);

                int rows = SqlCmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Expense added successfully.");
                    txtExpenseID.Text = "";
                    txtExpenseDescription.Text = "";
                    dateTimePickerExpenseDate.Text = "";
                    txtExpenseAmount.Text = "";
                    txtBusinessCapital.Text = "";

                }
                else
                {
                    MessageBox.Show("Check your input.");
                }

                SqlConn.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("there is input issue: try again");
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {



            try
            {
                Decimal BusinessCapital = Convert.ToDecimal(txtBusinessCapital.Text);
                decimal GrandTotalProduct = Convert.ToDecimal(txtGrandTotalProduct.Text);
                decimal GrandTotalExpense = Convert.ToDecimal(txtGrandTotalExpense.Text);
                decimal BusinessProfit = BusinessCapital - (GrandTotalProduct + GrandTotalExpense);

                if (BusinessCapital > 0)
                {
                    if (GrandTotalProduct > 0)
                    {
                        if (GrandTotalExpense > 0)
                        {
                            txtGrandBusinessProfit.Text = BusinessProfit.ToString("c");
                            txtGrandTotalProduct.Text = GrandTotalProduct.ToString("c");
                            txtGrandTotalExpense.Text = GrandTotalExpense.ToString("c");
                        }
                        else
                        {
                            MessageBox.Show("Get inputs in fields.");
                            txtBusinessCapital.Text = "";
                            txtBusinessCapital.Focus();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something is wrong.");
                txtBusinessCapital.Text = "";
                txtBusinessCapital.Focus();
            }

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("caclc.exe");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                string cmdString = "SELECT * FROM Expense WHERE ExpenseID ='" + txtExpenseID.Text + "'";


                SqlCommand sqlCmd = new SqlCommand(cmdString, conn);
                SqlDataReader dr = sqlCmd.ExecuteReader();
                if (dr.Read())
                {
                    txtExpenseID.Text = dr.GetString(0);
                    cboProductCode.Text = dr.GetString(1);
                    txtExpenseDescription.Text = dr.GetString(2);
                    dateTimePickerExpenseDate.Text = dr.GetString(3);
                    txtExpenseAmount.Text = dr.GetString(4);

                }
                else
                {
                    MessageBox.Show("No Record Found with given Id.");
                }
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ExpenseID is invalid");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string connString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();


                string updatecmdString = "UPDATE Expense SET ExpenseID='" + txtExpenseID.Text + "', ProductCode ='" + cboProductCode.Text + "',ExpenseDescription ='" + txtExpenseDescription.Text + "', ExpenseDate ='" + dateTimePickerExpenseDate.Text + "', ExpenseAmount ='" + txtExpenseAmount.Text + "' WHERE ExpenseID='" + txtExpenseID.Text + "'";
                SqlCommand sqlCmd = new SqlCommand(updatecmdString, conn);

                int rows = sqlCmd.ExecuteNonQuery();//number of rows 
                if (rows > 0)
                {
                    MessageBox.Show("Update Successful.");
                    txtExpenseID.Text = "";
                    cboProductCode.Text = "";
                    txtExpenseDescription.Text = "";
                    dateTimePickerExpenseDate.Text = "";
                    txtExpenseAmount.Text = "";
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
                conn.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("ExpenseID is invalid");
            }

        }

        private void btnGetTotalProduct_Click(object sender, EventArgs e)
        {
            string ConnString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(ConnString);
            SqlConn.Open();

            string CmdString = "SELECT SUM(UnitPrice) FROM Inventory";
            SqlCommand SqlCmd = new SqlCommand(CmdString, SqlConn);
            SqlDataReader dreader = SqlCmd.ExecuteReader();
            if (dreader.Read())
            {
                txtGrandTotalProduct.Text = dreader.GetDecimal(0).ToString();
            }

        }

        private void btnGetTotalExpense_Click(object sender, EventArgs e)
        {
            string ConnString = "Data Source=" + Path.Combine("LAPTOP-8CB24A9F", "NEWSQL") + ";Initial Catalog=BakayMiniBizz;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(ConnString);
            SqlConn.Open();

            string CmdString = "SELECT SUM(ExpenseAmount) FROM Expense";
            SqlCommand SqlCmd = new SqlCommand(CmdString, SqlConn);
            SqlDataReader dreader = SqlCmd.ExecuteReader();
            if (dreader.Read())
            {
                txtGrandTotalExpense.Text = dreader.GetDecimal(0).ToString();
            }

        }

        private void expenseMaintenanceDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
    

