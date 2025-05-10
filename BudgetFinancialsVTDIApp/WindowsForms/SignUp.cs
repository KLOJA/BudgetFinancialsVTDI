using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetFinancialsVTDIApp
{
    public partial class SignUpForm : Form
    {
        private readonly BudgetFinancialsDBEntities budgetFinancialsDBEntities;

        public SignUpForm()
        {
            InitializeComponent();
            budgetFinancialsDBEntities = new BudgetFinancialsDBEntities();
        }

        private void SubmitUserInfoBtn_Click(object sender, EventArgs e)
        {
            // Collect data from the form
            string firstName = FirstNameTXTBX.Text;
            string lastName = LastNameTXTBX.Text;
            string userEmail = EmailTXTBX.Text;
            string password = PasswordTXTBX.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(userEmail) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ensure the database connection is open
                if (budgetFinancialsDBEntities.Database.Connection.State != System.Data.ConnectionState.Open)
                {
                    budgetFinancialsDBEntities.Database.Connection.Open();
                }

                // Create a new user object
                var newUser = new UsersTb
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = userEmail,
                    PasswordHash = password // Replace with hashed password in production
                };

                // Add the new user to the database
                budgetFinancialsDBEntities.UsersTbs.Add(newUser);
                budgetFinancialsDBEntities.SaveChanges();

                // Inform the user of successful submission
                MessageBox.Show("Your information has been submitted successfully! Please try logging in with your email and password.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoginPage loginPage = new LoginPage();
                loginPage.Show();
               
                // Close the signup form and return to the login page
                this.Close();

                
            }
            catch (Exception ex)
            {
                // Handle any errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
