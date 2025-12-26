using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Guna.UI2.WinForms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        SqlConnection cons = new SqlConnection("Data Source=DESKTOP-R6EN807\\SQLEXPRESS;Initial Catalog=carRental;Integrated Security=True;TrustServerCertificate=True");


        private void Populate()
        {

            try
            {
                cons.Open();
                string query = "SELECT * FROM user_table";

                using (SqlDataAdapter da = new SqlDataAdapter(query, cons))
                {
                    var ds = new DataSet();
                    da.Fill(ds);
                    UserDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                    cons.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UId.Text) || string.IsNullOrEmpty(UName.Text) || string.IsNullOrEmpty(UPass.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            try
            {
                cons.Open();
                string query = "INSERT INTO user_table (id, username, password) VALUES (@UserId, @UserName, @UserPassword)";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@UserId", UId.Text);
                    cmd.Parameters.AddWithValue("@UserName", UName.Text);
                    cmd.Parameters.AddWithValue("@UserPassword", UPass.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                    cons.Close();

                Populate();
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void users_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UId.Text))
            {
                MessageBox.Show("Please enter the User ID to delete.");
                return;
            }

            try
            {
                cons.Open();
                string query = "DELETE FROM user_table WHERE id = @UserId";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@UserId", UId.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                    cons.Close();

                Populate();
            }
        }

        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UId.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            UName.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            UPass.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UId.Text) || string.IsNullOrEmpty(UName.Text) || string.IsNullOrEmpty(UPass.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            try
            {
                cons.Open();
                string query = "UPDATE user_table SET username = @UserName, password = @UserPassword WHERE id = @UserId";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@UserId", UId.Text);
                    cmd.Parameters.AddWithValue("@UserName", UName.Text);
                    cmd.Parameters.AddWithValue("@UserPassword", UPass.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("No user found with the provided User ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                    cons.Close();

                Populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            cars main = new cars();
            main.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
