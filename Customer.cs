using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject

{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        SqlConnection cons = new SqlConnection("Data Source=DESKTOP-R6EN807\\SQLEXPRESS;Initial Catalog=carRental;Integrated Security=True;TrustServerCertificate=True");
        private void Populate()
        {

            try
            {
                cons.Open();
                string query = "SELECT * FROM CustomerTable";

                using (SqlDataAdapter da = new SqlDataAdapter(query, cons))
                {
                    var ds = new DataSet();
                    da.Fill(ds);
                    custDGV.DataSource = ds.Tables[0];
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
        private void Customer_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btn_addcust_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_cid.Text) || string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrEmpty(txt_address.Text) ||
                string.IsNullOrEmpty(txt_Phone.Text) || string.IsNullOrEmpty(txt_birth.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            try
            {
                cons.Open();
                string query = "INSERT INTO CustomerTable (CusId,CusName,CusAdd,CusEmail,CusPhone,CusBirth) VALUES (@cusid,@cusname,@cusadd,@cusemail,@cusphone,@cusbirth)";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@cusid", txt_cid.Text);
                    cmd.Parameters.AddWithValue("@cusname", txt_name.Text);
                    cmd.Parameters.AddWithValue("@cusadd", txt_address.Text);
                    cmd.Parameters.AddWithValue("@cusemail", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@cusphone", txt_Phone.Text);
                    cmd.Parameters.AddWithValue("@cusbirth", txt_birth.Text);

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

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_deletecust_Click(object sender, EventArgs e)
        {

            try
            {
                cons.Open();
                string query = "DELETE FROM CustomerTable WHERE CusId = @cusid";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@cusid", custDGV.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car successfully deleted");
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

        private void custDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cid.Text = custDGV.SelectedRows[0].Cells[0].Value.ToString();
            txt_name.Text = custDGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_address.Text = custDGV.SelectedRows[0].Cells[2].Value.ToString();
            txt_Email.Text = custDGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_Phone.Text = custDGV.SelectedRows[0].Cells[4].Value.ToString();
            txt_birth.Text = custDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_editcust_Click(object sender, EventArgs e)
        {
            try
            {
                cons.Open();
                string query = "UPDATE CustomerTable set  CusName = @cuname, CusAdd = @cuadd, CusEmail = @cuemail, CusPhone = @cuphone , CusBirth = @cubirth WHERE CusId = @cuid";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@cuname", txt_name.Text);
                    cmd.Parameters.AddWithValue("@cuadd", txt_address.Text);
                    cmd.Parameters.AddWithValue("@cuemail", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@cuphone", txt_Phone.Text);
                    cmd.Parameters.AddWithValue("@cubirth", txt_birth.Text);
                    cmd.Parameters.AddWithValue("@cuid", custDGV.SelectedRows[0].Cells[0].Value.ToString());
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("No Customer found with the provided Information.");
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
    }
}
