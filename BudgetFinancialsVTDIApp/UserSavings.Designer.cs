namespace BudgetFinancialsVTDIApp
{
    partial class UserSavingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSavingsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LogoSavP = new System.Windows.Forms.PictureBox();
            this.BudgetFinancialsLableSavP = new System.Windows.Forms.Label();
            this.AddToSavingsLbl = new System.Windows.Forms.Label();
            this.InterestRateLbl = new System.Windows.Forms.Label();
            this.StartingSavingsLbl = new System.Windows.Forms.Label();
            this.NewSavingsNameLbl = new System.Windows.Forms.Label();
            this.NewSavingsNameTXTBX = new System.Windows.Forms.TextBox();
            this.StartingSavingsTXTBX = new System.Windows.Forms.TextBox();
            this.InterestRateTXTBX = new System.Windows.Forms.TextBox();
            this.AddtoSavingsTXTBX = new System.Windows.Forms.TextBox();
            this.AddNewSavingsBtn = new System.Windows.Forms.Button();
            this.SavingsGoalLbl = new System.Windows.Forms.Label();
            this.SavingsGoalTXTBX = new System.Windows.Forms.TextBox();
            this.SavingsProgressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SavingsNameLbl = new System.Windows.Forms.Label();
            this.SavingsNameComboBX = new System.Windows.Forms.ComboBox();
            this.UpdateSavingsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateSavingsAddedCal = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.budgetFinancialsDBDataSetSavingsName = new BudgetFinancialsVTDIApp.BudgetFinancialsDBDataSetSavingsName();
            this.userSavingsTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSavingsTbTableAdapter = new BudgetFinancialsVTDIApp.BudgetFinancialsDBDataSetSavingsNameTableAdapters.UserSavingsTbTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSavP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavingsProgressChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetFinancialsDBDataSetSavingsName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSavingsTbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoSavP
            // 
            this.LogoSavP.BackColor = System.Drawing.Color.Transparent;
            this.LogoSavP.Image = ((System.Drawing.Image)(resources.GetObject("LogoSavP.Image")));
            this.LogoSavP.Location = new System.Drawing.Point(204, 12);
            this.LogoSavP.Name = "LogoSavP";
            this.LogoSavP.Size = new System.Drawing.Size(159, 154);
            this.LogoSavP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoSavP.TabIndex = 15;
            this.LogoSavP.TabStop = false;
            // 
            // BudgetFinancialsLableSavP
            // 
            this.BudgetFinancialsLableSavP.AutoSize = true;
            this.BudgetFinancialsLableSavP.BackColor = System.Drawing.Color.Transparent;
            this.BudgetFinancialsLableSavP.Font = new System.Drawing.Font("Sans Serif Collection", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetFinancialsLableSavP.Location = new System.Drawing.Point(369, 40);
            this.BudgetFinancialsLableSavP.Name = "BudgetFinancialsLableSavP";
            this.BudgetFinancialsLableSavP.Size = new System.Drawing.Size(502, 79);
            this.BudgetFinancialsLableSavP.TabIndex = 16;
            this.BudgetFinancialsLableSavP.Text = "Budget Financials";
            // 
            // AddToSavingsLbl
            // 
            this.AddToSavingsLbl.AutoSize = true;
            this.AddToSavingsLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddToSavingsLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToSavingsLbl.Location = new System.Drawing.Point(586, 490);
            this.AddToSavingsLbl.Name = "AddToSavingsLbl";
            this.AddToSavingsLbl.Size = new System.Drawing.Size(170, 29);
            this.AddToSavingsLbl.TabIndex = 17;
            this.AddToSavingsLbl.Text = "Add to Savings";
            // 
            // InterestRateLbl
            // 
            this.InterestRateLbl.AutoSize = true;
            this.InterestRateLbl.BackColor = System.Drawing.Color.Transparent;
            this.InterestRateLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateLbl.Location = new System.Drawing.Point(43, 350);
            this.InterestRateLbl.Name = "InterestRateLbl";
            this.InterestRateLbl.Size = new System.Drawing.Size(200, 29);
            this.InterestRateLbl.TabIndex = 18;
            this.InterestRateLbl.Text = "Interest Rate P.A.";
            // 
            // StartingSavingsLbl
            // 
            this.StartingSavingsLbl.AutoSize = true;
            this.StartingSavingsLbl.BackColor = System.Drawing.Color.Transparent;
            this.StartingSavingsLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingSavingsLbl.Location = new System.Drawing.Point(43, 273);
            this.StartingSavingsLbl.Name = "StartingSavingsLbl";
            this.StartingSavingsLbl.Size = new System.Drawing.Size(249, 29);
            this.StartingSavingsLbl.TabIndex = 19;
            this.StartingSavingsLbl.Text = "Enter Starting Savings";
            // 
            // NewSavingsNameLbl
            // 
            this.NewSavingsNameLbl.AutoSize = true;
            this.NewSavingsNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.NewSavingsNameLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSavingsNameLbl.Location = new System.Drawing.Point(43, 196);
            this.NewSavingsNameLbl.Name = "NewSavingsNameLbl";
            this.NewSavingsNameLbl.Size = new System.Drawing.Size(282, 29);
            this.NewSavingsNameLbl.TabIndex = 20;
            this.NewSavingsNameLbl.Text = "Enter New Savings Name";
            // 
            // NewSavingsNameTXTBX
            // 
            this.NewSavingsNameTXTBX.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewSavingsNameTXTBX.Location = new System.Drawing.Point(48, 228);
            this.NewSavingsNameTXTBX.Name = "NewSavingsNameTXTBX";
            this.NewSavingsNameTXTBX.Size = new System.Drawing.Size(245, 30);
            this.NewSavingsNameTXTBX.TabIndex = 21;
            // 
            // StartingSavingsTXTBX
            // 
            this.StartingSavingsTXTBX.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingSavingsTXTBX.Location = new System.Drawing.Point(48, 305);
            this.StartingSavingsTXTBX.Name = "StartingSavingsTXTBX";
            this.StartingSavingsTXTBX.Size = new System.Drawing.Size(196, 30);
            this.StartingSavingsTXTBX.TabIndex = 22;
            // 
            // InterestRateTXTBX
            // 
            this.InterestRateTXTBX.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InterestRateTXTBX.Location = new System.Drawing.Point(48, 382);
            this.InterestRateTXTBX.Name = "InterestRateTXTBX";
            this.InterestRateTXTBX.Size = new System.Drawing.Size(78, 30);
            this.InterestRateTXTBX.TabIndex = 23;
            // 
            // AddtoSavingsTXTBX
            // 
            this.AddtoSavingsTXTBX.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddtoSavingsTXTBX.Location = new System.Drawing.Point(591, 522);
            this.AddtoSavingsTXTBX.Name = "AddtoSavingsTXTBX";
            this.AddtoSavingsTXTBX.Size = new System.Drawing.Size(165, 30);
            this.AddtoSavingsTXTBX.TabIndex = 24;
            // 
            // AddNewSavingsBtn
            // 
            this.AddNewSavingsBtn.Location = new System.Drawing.Point(48, 518);
            this.AddNewSavingsBtn.Name = "AddNewSavingsBtn";
            this.AddNewSavingsBtn.Size = new System.Drawing.Size(277, 40);
            this.AddNewSavingsBtn.TabIndex = 25;
            this.AddNewSavingsBtn.Text = "Add New Savings. ";
            this.AddNewSavingsBtn.UseVisualStyleBackColor = true;
            // 
            // SavingsGoalLbl
            // 
            this.SavingsGoalLbl.AutoSize = true;
            this.SavingsGoalLbl.BackColor = System.Drawing.Color.Transparent;
            this.SavingsGoalLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsGoalLbl.Location = new System.Drawing.Point(43, 430);
            this.SavingsGoalLbl.Name = "SavingsGoalLbl";
            this.SavingsGoalLbl.Size = new System.Drawing.Size(148, 29);
            this.SavingsGoalLbl.TabIndex = 27;
            this.SavingsGoalLbl.Text = "Savings Goal";
            // 
            // SavingsGoalTXTBX
            // 
            this.SavingsGoalTXTBX.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsGoalTXTBX.Location = new System.Drawing.Point(48, 462);
            this.SavingsGoalTXTBX.Name = "SavingsGoalTXTBX";
            this.SavingsGoalTXTBX.Size = new System.Drawing.Size(138, 30);
            this.SavingsGoalTXTBX.TabIndex = 28;
            // 
            // SavingsProgressChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SavingsProgressChart.ChartAreas.Add(chartArea2);
            this.SavingsProgressChart.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            legend2.Name = "Legend1";
            this.SavingsProgressChart.Legends.Add(legend2);
            this.SavingsProgressChart.Location = new System.Drawing.Point(504, 148);
            this.SavingsProgressChart.Name = "SavingsProgressChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Savings Goal";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Current Savings";
            this.SavingsProgressChart.Series.Add(series3);
            this.SavingsProgressChart.Series.Add(series4);
            this.SavingsProgressChart.Size = new System.Drawing.Size(693, 311);
            this.SavingsProgressChart.TabIndex = 26;
            this.SavingsProgressChart.Text = "Savings Progress";
            title2.Name = "Savings Progress";
            title2.Text = "Savings Progress";
            this.SavingsProgressChart.Titles.Add(title2);
            this.SavingsProgressChart.UseWaitCursor = true;
            // 
            // SavingsNameLbl
            // 
            this.SavingsNameLbl.AutoSize = true;
            this.SavingsNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.SavingsNameLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsNameLbl.Location = new System.Drawing.Point(817, 490);
            this.SavingsNameLbl.Name = "SavingsNameLbl";
            this.SavingsNameLbl.Size = new System.Drawing.Size(162, 29);
            this.SavingsNameLbl.TabIndex = 29;
            this.SavingsNameLbl.Text = "Savings Name";
            // 
            // SavingsNameComboBX
            // 
            this.SavingsNameComboBX.DataSource = this.userSavingsTbBindingSource;
            this.SavingsNameComboBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SavingsNameComboBX.FormattingEnabled = true;
            this.SavingsNameComboBX.Location = new System.Drawing.Point(815, 525);
            this.SavingsNameComboBX.Name = "SavingsNameComboBX";
            this.SavingsNameComboBX.Size = new System.Drawing.Size(164, 28);
            this.SavingsNameComboBX.TabIndex = 30;
            // 
            // UpdateSavingsBtn
            // 
            this.UpdateSavingsBtn.Location = new System.Drawing.Point(756, 598);
            this.UpdateSavingsBtn.Name = "UpdateSavingsBtn";
            this.UpdateSavingsBtn.Size = new System.Drawing.Size(277, 40);
            this.UpdateSavingsBtn.TabIndex = 31;
            this.UpdateSavingsBtn.Text = "Update Savings";
            this.UpdateSavingsBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1011, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Date Savings Added";
            // 
            // DateSavingsAddedCal
            // 
            this.DateSavingsAddedCal.Location = new System.Drawing.Point(1016, 523);
            this.DateSavingsAddedCal.Name = "DateSavingsAddedCal";
            this.DateSavingsAddedCal.Size = new System.Drawing.Size(200, 26);
            this.DateSavingsAddedCal.TabIndex = 33;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 33);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debtToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // debtToolStripMenuItem
            // 
            this.debtToolStripMenuItem.Name = "debtToolStripMenuItem";
            this.debtToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.debtToolStripMenuItem.Text = "Debt";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            // 
            // budgetFinancialsDBDataSetSavingsName
            // 
            this.budgetFinancialsDBDataSetSavingsName.DataSetName = "BudgetFinancialsDBDataSetSavingsName";
            this.budgetFinancialsDBDataSetSavingsName.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSavingsTbBindingSource
            // 
            this.userSavingsTbBindingSource.DataMember = "UserSavingsTb";
            this.userSavingsTbBindingSource.DataSource = this.budgetFinancialsDBDataSetSavingsName;
            // 
            // userSavingsTbTableAdapter
            // 
            this.userSavingsTbTableAdapter.ClearBeforeFill = true;
            // 
            // UserSavingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.DateSavingsAddedCal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateSavingsBtn);
            this.Controls.Add(this.SavingsNameComboBX);
            this.Controls.Add(this.SavingsNameLbl);
            this.Controls.Add(this.SavingsGoalTXTBX);
            this.Controls.Add(this.SavingsGoalLbl);
            this.Controls.Add(this.SavingsProgressChart);
            this.Controls.Add(this.AddNewSavingsBtn);
            this.Controls.Add(this.AddtoSavingsTXTBX);
            this.Controls.Add(this.InterestRateTXTBX);
            this.Controls.Add(this.StartingSavingsTXTBX);
            this.Controls.Add(this.NewSavingsNameTXTBX);
            this.Controls.Add(this.NewSavingsNameLbl);
            this.Controls.Add(this.StartingSavingsLbl);
            this.Controls.Add(this.InterestRateLbl);
            this.Controls.Add(this.AddToSavingsLbl);
            this.Controls.Add(this.BudgetFinancialsLableSavP);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LogoSavP);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserSavingsForm";
            this.Text = "Savings";
            // Inside InitializeComponent method
            this.AddNewSavingsBtn.Click += new System.EventHandler(this.AddNewSavingsBtn_Click);
            // Inside InitializeComponent method
            this.UpdateSavingsBtn.Click += new System.EventHandler(this.UpdateSavingsBtn_Click);

            ((System.ComponentModel.ISupportInitialize)(this.LogoSavP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavingsProgressChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetFinancialsDBDataSetSavingsName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSavingsTbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoSavP;
        private System.Windows.Forms.Label BudgetFinancialsLableSavP;
        private System.Windows.Forms.Label AddToSavingsLbl;
        private System.Windows.Forms.Label InterestRateLbl;
        private System.Windows.Forms.Label StartingSavingsLbl;
        private System.Windows.Forms.Label NewSavingsNameLbl;
        private System.Windows.Forms.TextBox NewSavingsNameTXTBX;
        private System.Windows.Forms.TextBox StartingSavingsTXTBX;
        private System.Windows.Forms.TextBox InterestRateTXTBX;
        private System.Windows.Forms.TextBox AddtoSavingsTXTBX;
        private System.Windows.Forms.Button AddNewSavingsBtn;
        private System.Windows.Forms.Label SavingsGoalLbl;
        private System.Windows.Forms.TextBox SavingsGoalTXTBX;
        private System.Windows.Forms.DataVisualization.Charting.Chart SavingsProgressChart;
        private System.Windows.Forms.Label SavingsNameLbl;
        private System.Windows.Forms.ComboBox SavingsNameComboBX;
        private System.Windows.Forms.Button UpdateSavingsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateSavingsAddedCal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private BudgetFinancialsDBDataSetSavingsName budgetFinancialsDBDataSetSavingsName;
        private System.Windows.Forms.BindingSource userSavingsTbBindingSource;
        private BudgetFinancialsDBDataSetSavingsNameTableAdapters.UserSavingsTbTableAdapter userSavingsTbTableAdapter;
    }
}