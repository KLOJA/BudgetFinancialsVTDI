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
    public partial class LoginPage : Form
    {
        private readonly BudgetFinancialsDBEntities budgetFinancialsDBEntities;
        private static readonly object _lock = new object();
        private static BudgetFinancialsDBEntities _instance; // Added missing static field

        public LoginPage()
        {
            InitializeComponent();
            // Use the shared DbContext instance
            budgetFinancialsDBEntities = Instance; // Updated to use the static Instance property
        }

        public static BudgetFinancialsDBEntities Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BudgetFinancialsDBEntities();
                        }
                    }
                }
                return _instance;
            }
        }
        // Add this to LoginPage.cs
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Retrieve user input
            string email = LPEmailTXTBX.Text.Trim();
            string password = LPPasswordTXTBX.Text.Trim();

            // Validate input
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Check credentials against the database
                var user = budgetFinancialsDBEntities.UsersTbs
                    .FirstOrDefault(u => u.Email == email && u.PasswordHash == password);

                if (user != null)
                {
                    // Successful login
                    MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update the MainWindowForm instantiation to pass the required 'firstName' parameter
                    MainWindowForm mainWindow = new MainWindowForm(user.FirstName);
                    mainWindow.Show();
                    this.Hide(); // Hide the login form
                }
                else
                {
                    // Invalid credentials
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during database access
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the SignUpForm when the sign-up link is clicked
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide(); // Optionally hide the login form
        }
    }
}
  
