using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hourglass;
using MonProfProj.Db;
using static MonProfProj.formVisitDate;

namespace MonProfProj
{
   

    public partial class formAddEvents : Form
    {

        public class Master
        {
            public int MasterId { get; set; }
            public string MastersName { get; set; }
        }

        public class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }

        public DateTime start = DateTime.Now;
        public DateTime end = DateTime.Now;

        private readonly DbConnection _sqlConnection;
        public event EventHandler DataSaved;

        public formAddEvents()
        {
            _sqlConnection = new DbConnection();
            InitializeComponent();
            LoadMastersIntoComboBox();
            LoadCategoryIntoComboBox();
        }

        private void formAddEvents_Load(object sender, EventArgs e)
        {
            StartDatePicker.Value = start;
            EndDatePicker.Value = end;


        }

        private void LoadCategoryIntoComboBox()
        {
            DbConnection db = new DbConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Query to select CategoryId and CategoryName
                    string query = "SELECT CategoryId, CategoryName FROM [dbo].[Category]";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            var categories = new List<Category>();

                            while (reader.Read())
                            {
                                categories.Add(new Category
                                {
                                    CategoryId = reader.GetInt32(0),
                                    CategoryName = reader.GetString(1)
                                });
                            }

                            comboBox1.DataSource = categories;
                            comboBox1.DisplayMember = "CategoryName";
                            comboBox1.ValueMember = "CategoryId";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void SaveAppointment(Appointment newAppointment)
        {
            // Get the selected MasterId from the ComboBox
            newAppointment.MasterId = (int)comboBox2.SelectedValue;

            // Get the selected CategoryId from the ComboBox
            if (comboBox1.SelectedValue != null)
            {
                newAppointment.CategoryId = (int)comboBox1.SelectedValue;
            }
            else
            {
                MessageBox.Show("Please select a category.");
                return; // Exit if no category is selected
            }

            string insertQuery = @"
    INSERT INTO [dbo].[Appointment] 
    (Text, Description, CategoryId, StartDate, EndDate, MasterId)
    VALUES (@Text, @Description, @CategoryId, @StartDate, @EndDate, @MasterId)";

            using (SqlConnection conn = new DbConnection().GetConnection())
            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@Text", newAppointment.Text);
                cmd.Parameters.AddWithValue("@Description", newAppointment.Description ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CategoryId", newAppointment.CategoryId); // Use the selected CategoryId
                cmd.Parameters.AddWithValue("@StartDate", newAppointment.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", newAppointment.EndDate);
                cmd.Parameters.AddWithValue("@MasterId", newAppointment.MasterId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadMastersIntoComboBox()
        {
            DbConnection db = new DbConnection();

            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Query to select MasterId and MastersName
                    string query = "SELECT MasterId, MastersName FROM [dbo].[Master]";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Create a list of masters to bind to the ComboBox
                            var masters = new List<Master>();

                            while (reader.Read())
                            {
                                // Create a master object with MasterId and MastersName
                                masters.Add(new Master
                                {
                                    MasterId = reader.GetInt32(0),
                                    MastersName = reader.GetString(1)
                                });
                            }

                            // Bind the list to the ComboBox
                            comboBox2.DataSource = masters;
                            comboBox2.DisplayMember = "MastersName"; // Shows Master's name
                            comboBox2.ValueMember = "MasterId";      // Holds MasterId
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            this.Dispose();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string textInfo = textBox.Text.Trim();
            string descriptionInfo = DescriptionBox.Text.Trim();
            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = EndDatePicker.Value;

            if (string.IsNullOrEmpty(textInfo))
            {
                MessageBox.Show("Please enter the text information.");
                return;
            }
            if (string.IsNullOrEmpty(descriptionInfo))
            {
                MessageBox.Show("Please enter the description.");
                return;
            }
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Please select a master.");
                return;
            }
            try
            {
                using (var connection = _sqlConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO Appointment (Text, Description, CategoryId, StartDate, EndDate, MasterId) " +
                        "VALUES (@Text, @Description, @CategoryId, @StartDate, @EndDate, @MasterId)", connection))
                    {
                        command.Parameters.AddWithValue("@Text", textInfo);
                        command.Parameters.AddWithValue("@Description", descriptionInfo);
                        command.Parameters.AddWithValue("@CategoryId", comboBox1.SelectedValue); // Ensure this ID exists in the Category table
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);
                        command.Parameters.AddWithValue("@MasterId", comboBox2.SelectedValue); // Pass MasterId

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment successfully added!");

                            // Trigger the DataSaved event to notify formVisitDate
                            DataSaved?.Invoke(this, EventArgs.Empty);

                            this.Close(); // Close the form after successfully adding the appointment
                        }
                        else
                        {
                            MessageBox.Show("No rows were inserted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding appointment: {ex.Message}");
            }
        }
    }
}
