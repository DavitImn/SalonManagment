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
using MonProfProj.Db;

namespace MonProfProj
{
    public partial class formMasters : Form
    {
        public formMasters()
        {
            InitializeComponent();
            LoadMastersIntoDataGridView();
        }

        private void LoadMastersIntoDataGridView()
        {
            // Create an instance of your DbConnection class
            DbConnection db = new DbConnection();

            // Open the connection
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();

                    // Query to select all required columns from Master table
                    string query = "SELECT MastersName, WorkDays, Phone, Percentage FROM [dbo].[Master]";

                    // Create a DataTable to hold the data
                    DataTable dt = new DataTable();

                    // Create a SQL Data Adapter
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        // Fill the DataTable with the results from the query
                        da.Fill(dt);

                        // Bind the DataTable to the DataGridView
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    conn.Close();
                }
            }
        }
    }
}
