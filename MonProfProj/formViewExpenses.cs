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
    public partial class formViewExpenses : Form
    {
        private readonly DbConnection _sqlConnection;
        public formViewExpenses()
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
                var command = new SqlCommand("SELECT ExpenseType, Amount, ExpenseMonth, Description FROM TotalExpenses", connection);
                //      command.Parameters.Add("@MasterName" , "Emily Clark");
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    dataGridView1.Rows.Clear();

                    while (reader.Read())  // Check if there is data to read
                    {
                        // Retrieve values from the database
                        string expenseType = reader["ExpenseType"].ToString();
                        decimal Amount = (decimal)reader["Amount"];
                        string expenseDate = reader["ExpenseMonth"].ToString();
                        string description = reader["Description"].ToString();

                        // Add a row to the DataGridView
                        dataGridView1.Rows.Add(expenseType, Amount, expenseDate, description);
                    }
                }

                connection.Close();
            }
        }
    }
}
