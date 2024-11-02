using MonProfProj.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MonProfProj
{
    public partial class formViewIncomes : Form
    {
        private readonly DbConnection _sqlConnection;
        public formViewIncomes()
        {
            InitializeComponent();
            _sqlConnection = new DbConnection();
            FillWithData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void FillWithData()
        {
            using (var connection = _sqlConnection.GetConnection())
            {
                var command = new SqlCommand("SELECT MasterName, AmountPaid FROM TotalRevenue", connection);
          //      command.Parameters.Add("@MasterName" , "Emily Clark");
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    while (reader.Read())  // Check if there is data to read
                    {
                        // Retrieve values from the database
                        string masterName = reader["MasterName"].ToString();
                        decimal amountPaid = (decimal)reader["AmountPaid"];

                        // Add a row to the DataGridView
                        dataGridView1.Rows.Add(masterName, amountPaid);
                    }
                }

                connection.Close();
            }
        }
    }
}
