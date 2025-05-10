using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetFinancialsVTDIApp.DataAccess;

namespace BudgetFinancialsVTDIApp
{
    public partial class UserSavingsForm : Form
    {
        private readonly BudgetFinancialsDBEntities budgetFinancialsDBEntities;

        public UserSavingsForm()
        {
            InitializeComponent();
            budgetFinancialsDBEntities = new BudgetFinancialsDBEntities();
        }

        private void AddNewSavingsBtn_Click(object sender, EventArgs e)
        {
            // Collect data from the form
            string savingsName = NewSavingsNameTXTBX.Text;
            decimal startingSavings;
            decimal.TryParse(StartingSavingsTXTBX.Text, out startingSavings);
            decimal interestRate;
            decimal.TryParse(InterestRateTXTBX.Text, out interestRate);
            decimal savingsGoal;
            decimal.TryParse(SavingsGoalTXTBX.Text, out savingsGoal);

            // Validate input
            if (string.IsNullOrWhiteSpace(savingsName) || startingSavings <= 0 || interestRate < 0 || savingsGoal <= 0)
            {
                MessageBox.Show("Please provide valid inputs for all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ensure a valid UserID is assigned to satisfy the foreign key constraint
                int userId = GetCurrentUserId(); // Replace with your logic to fetch the current user's ID

                if (userId <= 0)
                {
                    MessageBox.Show("Invalid user. Please ensure you are logged in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create a new savings record
                var newSavings = new UserSavingsTb
                {
                    UserID = userId, // Assign the UserID to satisfy the foreign key constraint
                    SavingsName = savingsName,
                    StartingSavings = (int)startingSavings,
                    SavingsInterestRate = (int)interestRate,
                    SavingsGoal = (int)savingsGoal,
                };

                // Add the new savings to the database
                budgetFinancialsDBEntities.UserSavingsTbs.Add(newSavings);
                budgetFinancialsDBEntities.SaveChanges();

                MessageBox.Show("New savings added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                MessageBox.Show($"An error occurred: {ex.InnerException?.InnerException?.Message ?? ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSavingsBtn_Click(object sender, EventArgs e)
        {
            // Collect data for updating savings
            string selectedSavingsName = SavingsNameComboBX.SelectedItem?.ToString();
            int addToSavings; // Change to int to match the database type
            int.TryParse(AddtoSavingsTXTBX.Text, out addToSavings); // Ensure parsing to int
            DateTime selectedDate = DateSavingsAddedCal.Value;

            // Validate input
            if (string.IsNullOrWhiteSpace(selectedSavingsName))
            {
                MessageBox.Show("Please select a savings name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (addToSavings <= 0)
            {
                MessageBox.Show("Please provide a valid amount to add to savings.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Update the savings record
                var savingsToUpdate = budgetFinancialsDBEntities.UserSavingsTbs
                    .FirstOrDefault(s => s.SavingsName == selectedSavingsName);

                if (savingsToUpdate != null)
                {
                    savingsToUpdate.CurrentSavings = addToSavings; // Directly set the new amount
                    savingsToUpdate.DateSavingsUpdate = selectedDate; // Update the date
                    budgetFinancialsDBEntities.SaveChanges();

                    MessageBox.Show("Savings updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No savings record found for the selected name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetCurrentUserId()
        {
            // Assuming the current user's email is stored in a session or configuration
            string currentUserEmail = "user@example.com"; // Replace with actual logic to fetch the email
            var userService = new UserService(new BudgetFinancialsDBEntities()); // Use the correct DbContext instance
            return userService.GetCurrentUserId(currentUserEmail);
        }
    }
}
