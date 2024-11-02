using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MonProfProj.Db;
using System.Windows.Forms;

namespace MonProfProj.Models
{
    public class ExpenseManager : DbConnection
    {

        private readonly DbConnection _sqlConnection;

        public ExpenseManager()
        {
            _sqlConnection = new DbConnection();
        }

        public void AddExpense(DateTime expenseMonth, string expenseType, decimal amount, string description)
        {
            // SQL query to insert a new row into the TotalExpenses table
            string query = "INSERT INTO TotalExpenses (ExpenseMonth, ExpenseType, Amount, Description) " +
                           "VALUES (@ExpenseMonth, @ExpenseType, @Amount, @Description)";

            // Using 'using' statement to ensure proper disposal of resources
            using (var connection = _sqlConnection.GetConnection())
            {
                try
                {
                    // Open the SQL connection
                    connection.Open();

                    // Create an SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Format the DateTime to a string in the desired format (yyyy-MM-dd)
                        string formattedDate = expenseMonth.ToString("dd-MM-yyyy");

                        // Add the parameters for the query
                        command.Parameters.AddWithValue("@ExpenseMonth", formattedDate); // Use the formatted string
                        command.Parameters.AddWithValue("@ExpenseType", expenseType);
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Description", description ?? (object)DBNull.Value);

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Optional: Inform how many rows were inserted
                        Console.WriteLine($"{rowsAffected} row(s) inserted.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that might occur
                    MessageBox.Show("This is a simple message.", $"{ex.Message}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}