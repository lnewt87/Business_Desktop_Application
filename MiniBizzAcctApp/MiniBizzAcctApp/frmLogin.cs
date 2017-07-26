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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
            txtPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            String UserID = txtUserId.Text;
            String password = txtPassword.Text;
            string dbpassword;

            

            SqlConnection con;
            con = new SqlConnection("Data Source="+ Path.Combine("LAPTOP-8CB24A9F", "NEWSQL")+";Initial Catalog=BakayMiniBizz;Integrated Security=True");
            con.Open();

            string cmdString = "SELECT [UserID], [Password] FROM [BakayMiniBizz].[dbo].[Login] WHERE UserID ='" + UserID + "'";
            SqlCommand sqlCmd = new SqlCommand(cmdString, con);

            SqlDataReader dr = sqlCmd.ExecuteReader();

            if (dr.Read())
            {
                dbpassword = dr.GetString(1);
                if (password.Equals(dbpassword))
                {
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials pls try again");
                }


            }
            con.Close();
          
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
            txtPassword.Text = "";


        }

        private void frmLogin_TextChanged(object sender, EventArgs e)
        {
            txtUserId.Focus();
        }
    }
}
