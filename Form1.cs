using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace TestProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-2SBJ98E\\SQLEXPRESS;Initial Catalog=TestDB;Persist Security Info=True;User ID=sa;Password=abc123;Encrypt=True;Trust Server Certificate=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = 
            new SqlCommand("Select * from UserTable where UserName = @UserName and Password = @Password", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            if (dt.Rows.Count > 0)
            {
                UserForm frm = new UserForm();
                frm.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }


        }
    }
}
