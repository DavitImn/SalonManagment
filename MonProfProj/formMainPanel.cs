using MonProfProj.Db;
using MonProfProj.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonProfProj
{
    public partial class formMainPanel : Form
    {
        
        private readonly DbConnection _sqlConnection;
       
        public formMainPanel()
        {
            InitializeComponent();
            _sqlConnection = new DbConnection();
            TotalIncome();
            FillUpWIthDataLbToTalExpenses();
        }

      

        public void FillUpWIthDataLbToTalExpenses()
        {
            using (var connection = _sqlConnection.GetConnection())
            {
                var command = new SqlCommand("select Sum(Amount) as TotalExpenses from TotalExpenses", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())  // Check if there is data to read
                    {

                        string totalExpenses = reader["TotalExpenses"] != DBNull.Value ? reader["TotalExpenses"].ToString() : "0";
                        LbTotalExpenses.Text = totalExpenses;
                    }
                    else
                    {
                        LbTotalExpenses.Text = "0";  // Handle case when no data is present
                    }
                }

                connection.Close();
            }
        }
        public void TotalIncome()
        {
            using (var connection = _sqlConnection.GetConnection())
            {
                var command = new SqlCommand("select Sum(AmountPaid) as TotalRevenue from TotalRevenue", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())  // Check if there is data to read
                    {

                        string totalRevenue = reader["TotalRevenue"] != DBNull.Value ? reader["TotalRevenue"].ToString() : "0";
                        LbTotalIncomes.Text = totalRevenue;
                    }
                    else
                    {
                        LbTotalIncomes.Text = "0";  // Handle case when no data is present
                    }
                }

                connection.Close();
            }
        }

        private void TotalIncomes_Click(object sender, EventArgs e)
        {

        }
        AddExpenses addexpensesform = new AddExpenses();
        private void button1_Click(object sender, EventArgs e)
        {
            FillUpWIthDataLbToTalExpenses();
                addexpensesform = new AddExpenses();
                addexpensesform.Show();
        }

        private void LbTotalExpenses_Click(object sender, EventArgs e)
        {

        }
    }
}