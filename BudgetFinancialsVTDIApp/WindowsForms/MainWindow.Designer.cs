namespace BudgetFinancialsVTDIApp
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.BudgetFinancialsLableMW = new System.Windows.Forms.Label();
            this.LogoMW = new System.Windows.Forms.PictureBox();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.MainPgUserNameTXTBX = new System.Windows.Forms.TextBox();
            this.CurrentSavingsLbl = new System.Windows.Forms.Label();
            this.CurrentDebtLbl = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.budgetFinancialsDBDataSetDebt = new BudgetFinancialsVTDIApp.BudgetFinancialsDBDataSetDebt();
            this.userSavingsTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSavingsTbTableAdapter = new BudgetFinancialsVTDIApp.BudgetFinancialsDBDataSetDebtTableAdapters.UserSavingsTbTableAdapter();
            this.savingsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentSavingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingsGoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetFinancialsDBDataSet = new BudgetFinancialsVTDIApp.BudgetFinancialsDBDataSet();
            this.userDebtTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDebtTbTableAdapter = new BudgetFinancialsVTDIApp.BudgetFinancialsDBDataSetTableAdapters.UserDebtTbTableAdapter();
            this.debtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDebtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LogoMW)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetFinancialsDBDataSetDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSavingsTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetFinancialsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDebtTbBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BudgetFinancialsLableMW
            // 
            this.BudgetFinancialsLableMW.AutoSize = true;
            this.BudgetFinancialsLableMW.BackColor = System.Drawing.Color.Transparent;
            this.BudgetFinancialsLableMW.Font = new System.Drawing.Font("Sans Serif Collection", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetFinancialsLableMW.Location = new System.Drawing.Point(435, 69);
            this.BudgetFinancialsLableMW.Name = "BudgetFinancialsLableMW";
            this.BudgetFinancialsLableMW.Size = new System.Drawing.Size(502, 79);
            this.BudgetFinancialsLableMW.TabIndex = 1;
            this.BudgetFinancialsLableMW.Text = "Budget Financials";
            // 
            // LogoMW
            // 
            this.LogoMW.BackColor = System.Drawing.Color.Transparent;
            this.LogoMW.Image = ((System.Drawing.Image)(resources.GetObject("LogoMW.Image")));
            this.LogoMW.Location = new System.Drawing.Point(289, 36);
            this.LogoMW.Name = "LogoMW";
            this.LogoMW.Size = new System.Drawing.Size(140, 137);
            this.LogoMW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoMW.TabIndex = 14;
            this.LogoMW.TabStop = false;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(42, 180);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(120, 29);
            this.WelcomeLbl.TabIndex = 15;
            this.WelcomeLbl.Text = "Welcome!";
            // 
            // MainPgUserNameTXTBX
            // 
            this.MainPgUserNameTXTBX.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPgUserNameTXTBX.Location = new System.Drawing.Point(46, 212);
            this.MainPgUserNameTXTBX.Name = "MainPgUserNameTXTBX";
            this.MainPgUserNameTXTBX.Size = new System.Drawing.Size(198, 35);
            this.MainPgUserNameTXTBX.TabIndex = 20;
            // 
            // CurrentSavingsLbl
            // 
            this.CurrentSavingsLbl.AutoSize = true;
            this.CurrentSavingsLbl.BackColor = System.Drawing.Color.Transparent;
            this.CurrentSavingsLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSavingsLbl.Location = new System.Drawing.Point(133, 282);
            this.CurrentSavingsLbl.Name = "CurrentSavingsLbl";
            this.CurrentSavingsLbl.Size = new System.Drawing.Size(182, 29);
            this.CurrentSavingsLbl.TabIndex = 21;
            this.CurrentSavingsLbl.Text = "Current Savings";
            // 
            // CurrentDebtLbl
            // 
            this.CurrentDebtLbl.AutoSize = true;
            this.CurrentDebtLbl.BackColor = System.Drawing.Color.Transparent;
            this.CurrentDebtLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDebtLbl.Location = new System.Drawing.Point(669, 282);
            this.CurrentDebtLbl.Name = "CurrentDebtLbl";
            this.CurrentDebtLbl.Size = new System.Drawing.Size(153, 29);
            this.CurrentDebtLbl.TabIndex = 22;
            this.CurrentDebtLbl.Text = "Current Debt";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.savingsToolStripMenuItem,
            this.debtToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 33);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // savingsToolStripMenuItem
            // 
            this.savingsToolStripMenuItem.Name = "savingsToolStripMenuItem";
            this.savingsToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.savingsToolStripMenuItem.Text = "Savings";
            // 
            // debtToolStripMenuItem
            // 
            this.debtToolStripMenuItem.Name = "debtToolStripMenuItem";
            this.debtToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.debtToolStripMenuItem.Text = "Debts";
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
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.debtNameDataGridViewTextBoxColumn,
            this.debtTypeDataGridViewTextBoxColumn,
            this.currentDebtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userDebtTbBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(513, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(501, 245);
            this.dataGridView1.TabIndex = 26;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.savingsNameDataGridViewTextBoxColumn,
            this.currentSavingsDataGridViewTextBoxColumn,
            this.savingsGoalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.userSavingsTbBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 329);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(483, 245);
            this.dataGridView2.TabIndex = 27;
            // 
            // budgetFinancialsDBDataSetDebt
            // 
            this.budgetFinancialsDBDataSetDebt.DataSetName = "BudgetFinancialsDBDataSetDebt";
            this.budgetFinancialsDBDataSetDebt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSavingsTbBindingSource
            // 
            this.userSavingsTbBindingSource.DataMember = "UserSavingsTb";
            this.userSavingsTbBindingSource.DataSource = this.budgetFinancialsDBDataSetDebt;
            // 
            // userSavingsTbTableAdapter
            // 
            this.userSavingsTbTableAdapter.ClearBeforeFill = true;
            // 
            // savingsNameDataGridViewTextBoxColumn
            // 
            this.savingsNameDataGridViewTextBoxColumn.DataPropertyName = "SavingsName";
            this.savingsNameDataGridViewTextBoxColumn.HeaderText = "SavingsName";
            this.savingsNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.savingsNameDataGridViewTextBoxColumn.Name = "savingsNameDataGridViewTextBoxColumn";
            this.savingsNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentSavingsDataGridViewTextBoxColumn
            // 
            this.currentSavingsDataGridViewTextBoxColumn.DataPropertyName = "CurrentSavings";
            this.currentSavingsDataGridViewTextBoxColumn.HeaderText = "CurrentSavings";
            this.currentSavingsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentSavingsDataGridViewTextBoxColumn.Name = "currentSavingsDataGridViewTextBoxColumn";
            this.currentSavingsDataGridViewTextBoxColumn.Width = 150;
            // 
            // savingsGoalDataGridViewTextBoxColumn
            // 
            this.savingsGoalDataGridViewTextBoxColumn.DataPropertyName = "SavingsGoal";
            this.savingsGoalDataGridViewTextBoxColumn.HeaderText = "SavingsGoal";
            this.savingsGoalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.savingsGoalDataGridViewTextBoxColumn.Name = "savingsGoalDataGridViewTextBoxColumn";
            this.savingsGoalDataGridViewTextBoxColumn.Width = 150;
            // 
            // budgetFinancialsDBDataSet
            // 
            this.budgetFinancialsDBDataSet.DataSetName = "BudgetFinancialsDBDataSet";
            this.budgetFinancialsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDebtTbBindingSource
            // 
            this.userDebtTbBindingSource.DataMember = "UserDebtTb";
            this.userDebtTbBindingSource.DataSource = this.budgetFinancialsDBDataSet;
            // 
            // userDebtTbTableAdapter
            // 
            this.userDebtTbTableAdapter.ClearBeforeFill = true;
            // 
            // debtNameDataGridViewTextBoxColumn
            // 
            this.debtNameDataGridViewTextBoxColumn.DataPropertyName = "DebtName";
            this.debtNameDataGridViewTextBoxColumn.HeaderText = "DebtName";
            this.debtNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.debtNameDataGridViewTextBoxColumn.Name = "debtNameDataGridViewTextBoxColumn";
            this.debtNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // debtTypeDataGridViewTextBoxColumn
            // 
            this.debtTypeDataGridViewTextBoxColumn.DataPropertyName = "DebtType";
            this.debtTypeDataGridViewTextBoxColumn.HeaderText = "DebtType";
            this.debtTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.debtTypeDataGridViewTextBoxColumn.Name = "debtTypeDataGridViewTextBoxColumn";
            this.debtTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentDebtDataGridViewTextBoxColumn
            // 
            this.currentDebtDataGridViewTextBoxColumn.DataPropertyName = "CurrentDebt";
            this.currentDebtDataGridViewTextBoxColumn.HeaderText = "CurrentDebt";
            this.currentDebtDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.currentDebtDataGridViewTextBoxColumn.Name = "currentDebtDataGridViewTextBoxColumn";
            this.currentDebtDataGridViewTextBoxColumn.Width = 150;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1104, 601);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CurrentDebtLbl);
            this.Controls.Add(this.CurrentSavingsLbl);
            this.Controls.Add(this.MainPgUserNameTXTBX);
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.LogoMW);
            this.Controls.Add(this.BudgetFinancialsLableMW);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindowForm";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoMW)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetFinancialsDBDataSetDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSavingsTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetFinancialsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDebtTbBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BudgetFinancialsLableMW;
        private System.Windows.Forms.PictureBox LogoMW;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.TextBox MainPgUserNameTXTBX;
        private System.Windows.Forms.Label CurrentSavingsLbl;
        private System.Windows.Forms.Label CurrentDebtLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BudgetFinancialsDBDataSetDebt budgetFinancialsDBDataSetDebt;
        private System.Windows.Forms.BindingSource userSavingsTbBindingSource;
        private BudgetFinancialsDBDataSetDebtTableAdapters.UserSavingsTbTableAdapter userSavingsTbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentSavingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingsGoalDataGridViewTextBoxColumn;
        private BudgetFinancialsDBDataSet budgetFinancialsDBDataSet;
        private System.Windows.Forms.BindingSource userDebtTbBindingSource;
        private BudgetFinancialsDBDataSetTableAdapters.UserDebtTbTableAdapter userDebtTbTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDebtDataGridViewTextBoxColumn;
    }
}