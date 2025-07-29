using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GameRentalApp
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Server=3ABDO1;Database=GameRentalApp;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGameId.Text) ||
                string.IsNullOrWhiteSpace(textBoxGameName.Text) ||
                string.IsNullOrWhiteSpace(textBoxGenre.Text))
            {
                MessageBox.Show("Please fill all Game fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO GAME (ATTRIBUTE_22, GENRENAME) VALUES (@Name, @Genre)";
                // Assuming ATTRIBUTE_22 is game name, ID is auto-generated or handled by DB.

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", textBoxGameName.Text);
                cmd.Parameters.AddWithValue("@Genre", textBoxGenre.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Game added successfully.");
                    ClearGameInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding game: " + ex.Message);
                }
            }
        }

        private void ClearGameInputs()
        {
            textBoxGameId.Text = "";
            textBoxGameName.Text = "";
            textBoxGenre.Text = "";
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAdminId.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdminName.Text))
            {
                MessageBox.Show("Please fill all Admin fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ADMIN (ADMINID_, FULLNAME_) VALUES (@AdminId, @AdminName)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AdminId", textBoxAdminId.Text);
                cmd.Parameters.AddWithValue("@AdminName", textBoxAdminName.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin added successfully.");
                    ClearAdminInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding admin: " + ex.Message);
                }
            }
        }

        private void ClearAdminInputs()
        {
            textBoxAdminId.Text = "";
            textBoxAdminName.Text = "";
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxClientId.Text) ||
                string.IsNullOrWhiteSpace(textBoxClientName.Text))
            {
                MessageBox.Show("Please fill all Client fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CLIENT (CLIENTID, FULLNAME) VALUES (@ClientId, @ClientName)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ClientId", textBoxClientId.Text);
                cmd.Parameters.AddWithValue("@ClientName", textBoxClientName.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client added successfully.");
                    ClearClientInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding client: " + ex.Message);
                }
            }
        }

        private void ClearClientInputs()
        {
            textBoxClientId.Text = "";
            textBoxClientName.Text = "";
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxVendorId.Text) ||
                string.IsNullOrWhiteSpace(textBoxVendorName.Text))
            {
                MessageBox.Show("Please fill all Vendor fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO VENDOR (VENDORID, VENDORNAME) VALUES (@VendorId, @VendorName)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@VendorId", textBoxVendorId.Text);
                cmd.Parameters.AddWithValue("@VendorName", textBoxVendorName.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vendor added successfully.");
                    ClearVendorInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding vendor: " + ex.Message);
                }
            }
        }

        private void ClearVendorInputs()
        {
            textBoxVendorId.Text = "";
            textBoxVendorName.Text = "";
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDeleteGameId.Text))
            {
                MessageBox.Show("Please enter a Game ID to delete.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM GAME WHERE ATTRIBUTE_22 = @GameName"; // or by ID if you have ID column
                SqlCommand cmd = new SqlCommand(query, con);
                // Here assuming ATTRIBUTE_22 is the game name because ID isn't clear.
                cmd.Parameters.AddWithValue("@GameName", textBoxDeleteGameId.Text);

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Game deleted successfully.");
                    else
                        MessageBox.Show("No matching game found.");
                    textBoxDeleteGameId.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting game: " + ex.Message);
                }
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDeleteClientId.Text))
            {
                MessageBox.Show("Please enter a Client ID to delete.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM CLIENT WHERE CLIENTID = @ClientId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ClientId", textBoxDeleteClientId.Text);

                try
                {
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Client deleted successfully.");
                    else
                        MessageBox.Show("No matching client found.");
                    textBoxDeleteClientId.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting client: " + ex.Message);
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (comboBoxDisplay.SelectedItem == null)
            {
                MessageBox.Show("Please select a category to display.");
                return;
            }

            string tableName = "";
            switch (comboBoxDisplay.SelectedItem.ToString())
            {
                case "Games":
                    tableName = "GAME";
                    break;
                case "Admins":
                    tableName = "ADMIN";
                    break;
                case "Clients":
                    tableName = "CLIENT";
                    break;
                case "Vendors":
                    tableName = "VENDOR";
                    break;
                default:
                    MessageBox.Show("Invalid selection.");
                    return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM " + tableName;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    dataGridViewDisplay.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying data: " + ex.Message);
                }
            }
        }
    }
}

