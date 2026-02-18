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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            getUsers();
        }
        SqlConnection conn =
        new SqlConnection("Data Source=DESKTOP-2SBJ98E\\SQLEXPRESS;Initial Catalog=TestDB;Persist Security Info=True;User ID=sa;Password=abc123;Encrypt=True;Trust Server Certificate=True");
        int UserId = 0;
        public bool ManageUsers(int UserId, String UserName,
            String Password, String Role, int Mode)
        {
            SqlCommand cmd = new SqlCommand("SP_ManageUsers", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Role", Role);
            cmd.Parameters.AddWithValue("@Mode", Mode);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
                return true;
            else
                return false;
        }
        public void getUsers()
        {
            SqlCommand cmd = new SqlCommand("Select * from UserTable", conn);
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            conn.Close();
            dgvUserList.DataSource = dt;
        }

        public void clearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool rs = ManageUsers(0, txtUsername.Text, txtPassword.Text, cmbRole.Text, 1);
            if (rs == true)
            {
                MessageBox.Show("User successfully created");
                getUsers();
                clearFields();
            }
            else
            {
                MessageBox.Show("Error occured in performing the required operation");
                clearFields();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserId = int.Parse(dgvUserList.SelectedRows[0].Cells["UserId"].Value.ToString());
            txtUsername.Text = dgvUserList.SelectedRows[0].Cells["UserName"].Value.ToString();
            txtPassword.Text = dgvUserList.SelectedRows[0].Cells["Password"].Value.ToString();
            txtConfirmPassword.Text = txtPassword.Text;
            cmbRole.Text = dgvUserList.SelectedRows[0].Cells["Role"].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool rs = ManageUsers(UserId, txtUsername.Text, txtPassword.Text, cmbRole.Text, 2);
            if (rs == true)
            {
                MessageBox.Show("User successfully updated");
                getUsers();
                clearFields();
            }
            else
            {
                MessageBox.Show("Error occured in performing the required operation");
                clearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool rs = ManageUsers(UserId, txtUsername.Text, txtPassword.Text, cmbRole.Text, 3);
            if (rs == true)
            {
                MessageBox.Show("User successfully deleted");
                getUsers();
                clearFields();
            }
            else
            {
                MessageBox.Show("Error occured in performing the required operation");
                clearFields();
            }

        }
    }
}
