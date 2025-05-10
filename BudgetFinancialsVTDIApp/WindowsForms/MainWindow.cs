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
    public partial class MainWindowForm : Form
    {
        private string loggedInUserFirstName;

        public MainWindowForm(string firstName)
        {
            InitializeComponent();
            loggedInUserFirstName = firstName;
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // Display the logged-in user's first name in the MainPgUserNameTXTBX
            MainPgUserNameTXTBX.Text = loggedInUserFirstName;

            //prevent user from editing the text box
            MainPgUserNameTXTBX.ReadOnly = true;

            // TODO: This line of code loads data into the 'budgetFinancialsDBDataSet.UserDebtTb' table. You can move, or remove it, as needed.
            this.userDebtTbTableAdapter.Fill(this.budgetFinancialsDBDataSet.UserDebtTb);
            // TODO: This line of code loads data into the 'budgetFinancialsDBDataSetDebt.UserSavingsTb' table. You can move, or remove it, as needed.
            this.userSavingsTbTableAdapter.Fill(this.budgetFinancialsDBDataSetDebt.UserSavingsTb);

            // Attach event handlers to menu items
            homeToolStripMenuItem.Click += HomeToolStripMenuItem_Click;
            savingsToolStripMenuItem.Click += SavingsToolStripMenuItem_Click;
            debtToolStripMenuItem.Click += DebtToolStripMenuItem_Click;
            settingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            exitProgramToolStripMenuItem.Click += ExitProgramToolStripMenuItem_Click;
        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on the Home page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Existing code remains unchanged
        private void SavingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Savings form
            UserSavingsForm savingsForm = new UserSavingsForm();
            savingsForm.Show();
        }

        private void DebtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Debt form
            UserDebt debtForm = new UserDebt();
            debtForm.Show();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the Settings form
            ProfileSettings settingsForm = new ProfileSettings();
            settingsForm.Show();
        }

        private void ExitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}
