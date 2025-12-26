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

namespace FinalProject
{
    public partial class CarRental : Form
    {
        public CarRental()
        {
            InitializeComponent();
        }
        SqlConnection cons = new SqlConnection("Data Source=DESKTOP-R6EN807\\SQLEXPRESS;Initial Catalog=carRental;Integrated Security=True;TrustServerCertificate=True");
        bool _bindingCustomers = false;
        private void FillCombo()
        {
            try
            {
                cons.Open();
                string query = "SELECT RegNum FROM CarTable"; // ✅ ALL cars (Yes + No)
                using (SqlCommand cmd = new SqlCommand(query, cons))
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(rdr);

                    carregtxt.ValueMember = "RegNum";
                    carregtxt.DisplayMember = "RegNum";
                    carregtxt.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cars: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open) cons.Close();
            }
        }


        private void Populate()
        {

            try
            {
                cons.Open();
                string query = "SELECT * FROM Rental_Table";
                using (SqlDataAdapter da = new SqlDataAdapter(query, cons))
                {
                    var ds = new DataSet();
                    da.Fill(ds);
                    RentalDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                {
                    cons.Close();
                }
            }
        }
        private void FillCustomers()
        {
            _bindingCustomers = true;
            try
            {
                cons.Open();
                string query = "SELECT CusId FROM CustomerTable";
                SqlCommand cmd = new SqlCommand(query, cons);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                custumers.ValueMember = "CusId";
                custumers.DisplayMember = "CusId";
                custumers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while filling the customers combo box: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                {
                    _bindingCustomers = false;
                    cons.Close();
                }
            }
        }
        private void fetchcusname()
        {
            if (_bindingCustomers) return;
            try
            {
                cons.Open();
                string query = "SELECT CusName FROM CustomerTable WHERE CusId = @customerId";
                SqlCommand cmd = new SqlCommand(query, cons);
                cmd.Parameters.AddWithValue("@customerId", custumers.SelectedValue.ToString());
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Nameofcustomer.Text = dt.Rows[0]["CusName"].ToString();
                }
                else
                {
                    Nameofcustomer.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching customer name: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                {
                    cons.Close();
                }
            }
        }
        private void UpdateOnRent(string availability)
        {
            try
            {
                if (cons.State == ConnectionState.Closed)
                {
                    cons.Open();
                }

                string query = "UPDATE CarTable SET Available = @available WHERE RegNum = @carReg";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@carReg", carregtxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@available", availability);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating car availability: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                {
                    cons.Close();
                }
            }
        }
        private void CarRental_Load(object sender, EventArgs e)
        {
            RentalDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RentalDGV.MultiSelect = false;
            UpdateOnRent("No");
            UpdateOnRent("Yes");
            FillCombo();
            FillCustomers();
            Populate();
        }



        private void custumers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (_bindingCustomers) return;
            fetchcusname();
        }

        private void carregtxt_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btn_addrent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_rentid.Text) || string.IsNullOrEmpty(custumers.Text) || string.IsNullOrEmpty(carregtxt.Text) ||
               string.IsNullOrEmpty(daterent.Text) || string.IsNullOrEmpty(datereturn.Text) || string.IsNullOrEmpty(Fees.Text))
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                try
                {
                    cons.Open();
                    string query = "INSERT INTO Rental_Table (RentId, CarReg, CustName, RentDate, ReturnDate, Fees) " +
                                   "VALUES (@rentid, @carreg, @cusname, @rentdate, @returndate, @fees)";
                    using (SqlCommand cmd = new SqlCommand(query, cons))
                    {
                        cmd.Parameters.AddWithValue("@rentid", txt_rentid.Text);
                        cmd.Parameters.AddWithValue("@carreg", carregtxt.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@cusname", custumers.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@rentdate", daterent.Value);
                        cmd.Parameters.AddWithValue("@returndate", datereturn.Value);
                        cmd.Parameters.AddWithValue("@fees", Fees.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Car successfully rented.");

                        UpdateOnRent("No");
                        Populate();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (cons.State == ConnectionState.Open)
                    {
                        cons.Close();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            cars main = new cars();
            main.Show();
        }

        private void btn_editrent_Click(object sender, EventArgs e)
        {
            if (RentalDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a rental entry to edit.");
                return;
            }

            if (string.IsNullOrEmpty(txt_rentid.Text) || string.IsNullOrEmpty(custumers.Text) || string.IsNullOrEmpty(carregtxt.Text) ||
                string.IsNullOrEmpty(daterent.Text) || string.IsNullOrEmpty(datereturn.Text) || string.IsNullOrEmpty(Fees.Text))
            {
                MessageBox.Show("Missing Information.");
                return;
            }

            DateTime rentDate = daterent.Value;
            DateTime returnDate = datereturn.Value;

            try
            {
                cons.Open();
                string query = "UPDATE Rental_Table SET CarReg = @carreg, CustName = @cusname, RentDate = @rentdate, ReturnDate = @returndate, Fees = @fees WHERE RentId = @rentid";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@rentid", txt_rentid.Text);
                    cmd.Parameters.AddWithValue("@carreg", carregtxt.Text.ToString());
                    cmd.Parameters.AddWithValue("@cusname", custumers.Text.ToString());
                    cmd.Parameters.AddWithValue("@rentdate", rentDate);
                    cmd.Parameters.AddWithValue("@returndate", returnDate);
                    cmd.Parameters.AddWithValue("@fees", Fees.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Rental entry updated successfully.");
                        Populate();
                    }
                    else
                    {
                        MessageBox.Show("No rental entry found with the given RentId.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                {
                    cons.Close();
                }
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void carregtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //private void RentalDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txt_rentid.Text = RentalDGV.SelectedRows[0].Cells[0].Value.ToString();
        //    carregtxt.Text = RentalDGV.SelectedRows[0].Cells[1].Value.ToString();
        //    custumers.Text = RentalDGV.SelectedRows[0].Cells[2].Value.ToString();
        //    daterent.Text = RentalDGV.SelectedRows[0].Cells[3].Value.ToString();
        //    datereturn.Text = RentalDGV.SelectedRows[0].Cells[4].Value.ToString();
        //    Fees.Text = RentalDGV.SelectedRows[0].Cells[5].Value.ToString();
        //}



        private void btn_deleterent_Click(object sender, EventArgs e)
        {
            try
            {
                cons.Open();
                string query = "DELETE FROM Rental_Table WHERE RentId = @rentid";
                using (SqlCommand cmd = new SqlCommand(query, cons))
                {
                    cmd.Parameters.AddWithValue("@rentid", RentalDGV.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car successfully deleted.");
                    txt_rentid.Clear();
                    Fees.Clear();
                    UpdateOnRent("Yes");
                    Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (cons.State == ConnectionState.Open)
                {
                    cons.Close();
                }
            }
        }

        private void RentalDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            DataGridViewRow row = RentalDGV.Rows[e.RowIndex];

            txt_rentid.Text = row.Cells[0].Value?.ToString() ?? "";
            string carReg = row.Cells[1].Value?.ToString() ?? "";
            string cusId = row.Cells[2].Value?.ToString() ?? "";

            // ✅ Ensure combo lists are ready
            FillCombo();
            FillCustomers();

            // ✅ Set selected values
            carregtxt.SelectedValue = carReg;
            custumers.SelectedValue = cusId;

            // ✅ Fill name (SelectionChangeCommitted won’t fire when you change SelectedValue by code)
            fetchcusname();

            // ✅ Dates + Fees
            daterent.Value = Convert.ToDateTime(row.Cells[3].Value);
            datereturn.Value = Convert.ToDateTime(row.Cells[4].Value);
            Fees.Text = row.Cells[5].Value?.ToString() ?? "";
        }
    }
}
