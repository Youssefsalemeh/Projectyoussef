using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection cons = new SqlConnection("Data Source=DESKTOP-R6EN807\\SQLEXPRESS;Initial Catalog=carRental;Integrated Security=True;TrustServerCertificate=True");
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                cons.Open();
                string query = "SELECT COUNT(*) FROM user_table WHERE username = @use AND password = @pass";

                SqlCommand cmd = new SqlCommand(query, cons);
                cmd.Parameters.AddWithValue("@use", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    this.Hide();
                    cars main = new cars();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cons.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
//login page
