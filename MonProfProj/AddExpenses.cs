using MonProfProj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonProfProj
{
    public partial class AddExpenses : Form
    {
        ExpenseManager _expenseManager = new ExpenseManager();
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshMethod();
            this.Dispose();
        }

        private void AddExpenses_Load(object sender, EventArgs e)
        {
            
        }

        public void RefreshMethod() 
        {
            formMainPanel formMainPanel = new formMainPanel();
            formMainPanel.FillUpWIthDataLbToTalExpenses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Initialize amount variable
            decimal amount;

            // Try to convert the text to a decimal
            bool isConversionSuccessful = decimal.TryParse(textBoxAmount.Text, out amount);

            // Get other inputs
            string ExpenseType = textBoxExpenseType.Text;
            string ExpenseDescription = textBoxDescription.Text;

            // Check if the conversion was successful
            if (!isConversionSuccessful)
            {
                // Show an error message if the amount is not valid
                MessageBox.Show("Please enter a valid decimal amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if the input is invalid
            }
            try
            {
                // Call the method to add the expense
                _expenseManager.AddExpense(DateTime.Now, ExpenseType, amount, ExpenseDescription);

                // Show success message after adding the expense
                MessageBox.Show("Bill Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshMethod();
        }

    }
}
