using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class addcars : Form
    {
        public addcars()
        {
            InitializeComponent();
        }
        SqlConnection cons = new SqlConnection("Data Source=DESKTOP-R6EN807\\SQLEXPRESS;Initial Catalog=carRental;Integrated Security=True;TrustServerCertificate=True");
        private void Populate()
        {

            try
            {
                cons.Open();
                string query = "SELECT * FROM CarTable";

                using (SqlDataAdapter da = new SqlDataAdapter(query, cons))
                {
                    var ds = new DataSet();
                    da.Fill(ds);
                    carDGV.DataSource = ds.Tables[0];
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

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_addcar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_regNo.Text) || string.IsNullOrEmpty(txt_model.Text) || string.IsNullOrEmpty(txt_brand.Text) ||
                string.IsNullOrEmpty(txt_model.Text) || string.IsNullOrEmpty(txtprice.Text) || string.IsNullOrEmpty(txt_available.Text)
                || string.IsNullOrEmpty(txt_color.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            try
            {
                cons.Open();
                string query = "INSERT INTO CarTable (RegNum,Brand,Model,Color,Available,Price) VALUES (@carReg,@carBrand,@carModel,@carColor,@carAvailable,@carPrice)";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@carReg", txt_regNo.Text);
                    cmd.Parameters.AddWithValue("@carBrand", txt_brand.Text);
                    cmd.Parameters.AddWithValue("@carModel", txt_model.Text);
                    cmd.Parameters.AddWithValue("@carColor", txt_color.Text);
                    cmd.Parameters.AddWithValue("@carAvailable", txt_available.Text);
                    cmd.Parameters.AddWithValue("@carPrice", txtprice.Text);

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

        private void addcars_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void btn_deletecar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_regNo.Text))
            {
                MessageBox.Show("Please enter the RegNo to delete.");
                return;
            }

            try
            {
                cons.Open();
                string query = "DELETE FROM CarTable WHERE RegNum = @carReg";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@carReg", txt_regNo.Text);
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

        private void carDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_regNo.Text = carDGV.SelectedRows[0].Cells[0].Value.ToString();
            txt_brand.Text = carDGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_model.Text = carDGV.SelectedRows[0].Cells[2].Value.ToString();
            txt_color.Text = carDGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_available.Text = carDGV.SelectedRows[0].Cells[4].Value.ToString();
            txtprice.Text = carDGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_editcar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_regNo.Text))
            {
                MessageBox.Show("Please enter the RegNo to edit.");
                return;
            }

            try
            {
                cons.Open();
                string query = "UPDATE CarTable SET Model = @model, Brand = @brand, Color = @color, Price = @price, Available = @available WHERE RegNum = @carReg";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@model", txt_model.Text);
                    cmd.Parameters.AddWithValue("@brand", txt_brand.Text);
                    cmd.Parameters.AddWithValue("@color", txt_color.Text);
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@available", txt_available.Text);
                    cmd.Parameters.AddWithValue("@carReg", txt_regNo.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Car successfully updated");
                    }
                    else
                    {
                        MessageBox.Show("No car found with the provided RegNo.");
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

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Available_Click(object sender, EventArgs e)
        {
            try
            {
                cons.Open();
                string query = "SELECT * FROM CarTable WHERE Available = 'yes'";

                using (SqlDataAdapter da = new SqlDataAdapter(query, cons))
                {
                    var ds = new DataSet();
                    da.Fill(ds);
                    carDGV.DataSource = ds.Tables[0];
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

        private void refleshbtn_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                cons.Open();
                string query = "SELECT * FROM CarTable WHERE RegNum = @reg";
                string regNum = text_search.Text;

                using (SqlDataAdapter da = new SqlDataAdapter(query, cons))
                {
                    da.SelectCommand.Parameters.AddWithValue("@reg", regNum);

                    var ds = new DataSet();
                    da.Fill(ds);
                    carDGV.DataSource = ds.Tables[0];
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
    }
}
