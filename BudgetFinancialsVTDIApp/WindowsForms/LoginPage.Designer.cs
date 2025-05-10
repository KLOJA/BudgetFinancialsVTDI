namespace BudgetFinancialsVTDIApp
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.BudgetFinancialsLableLP = new System.Windows.Forms.Label();
            this.LPEmailLbl = new System.Windows.Forms.Label();
            this.LPEmailTXTBX = new System.Windows.Forms.TextBox();
            this.LPPasswordTXTBX = new System.Windows.Forms.TextBox();
            this.LPPasswordLbl = new System.Windows.Forms.Label();
            this.SignUpLnkLbl = new System.Windows.Forms.LinkLabel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BudgetFinancialsLableLP
            // 
            this.BudgetFinancialsLableLP.AutoSize = true;
            this.BudgetFinancialsLableLP.BackColor = System.Drawing.Color.Transparent;
            this.BudgetFinancialsLableLP.Font = new System.Drawing.Font("Sans Serif Collection", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BudgetFinancialsLableLP.ForeColor = System.Drawing.Color.Black;
            this.BudgetFinancialsLableLP.Location = new System.Drawing.Point(12, 45);
            this.BudgetFinancialsLableLP.Name = "BudgetFinancialsLableLP";
            this.BudgetFinancialsLableLP.Size = new System.Drawing.Size(611, 99);
            this.BudgetFinancialsLableLP.TabIndex = 1;
            this.BudgetFinancialsLableLP.Text = "Budget Financials";
            // 
            // LPEmailLbl
            // 
            this.LPEmailLbl.AutoSize = true;
            this.LPEmailLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPEmailLbl.Location = new System.Drawing.Point(239, 188);
            this.LPEmailLbl.Name = "LPEmailLbl";
            this.LPEmailLbl.Size = new System.Drawing.Size(76, 29);
            this.LPEmailLbl.TabIndex = 15;
            this.LPEmailLbl.Text = "Email";
            // 
            // LPEmailTXTBX
            // 
            this.LPEmailTXTBX.Location = new System.Drawing.Point(137, 234);
            this.LPEmailTXTBX.Name = "LPEmailTXTBX";
            this.LPEmailTXTBX.Size = new System.Drawing.Size(283, 26);
            this.LPEmailTXTBX.TabIndex = 22;
            // 
            // LPPasswordTXTBX
            // 
            this.LPPasswordTXTBX.Location = new System.Drawing.Point(137, 343);
            this.LPPasswordTXTBX.Name = "LPPasswordTXTBX";
            this.LPPasswordTXTBX.Size = new System.Drawing.Size(283, 26);
            this.LPPasswordTXTBX.TabIndex = 23;
            // 
            // LPPasswordLbl
            // 
            this.LPPasswordLbl.AutoSize = true;
            this.LPPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.LPPasswordLbl.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPPasswordLbl.Location = new System.Drawing.Point(223, 297);
            this.LPPasswordLbl.Name = "LPPasswordLbl";
            this.LPPasswordLbl.Size = new System.Drawing.Size(115, 29);
            this.LPPasswordLbl.TabIndex = 24;
            this.LPPasswordLbl.Text = "Password";
            // 
            // SignUpLnkLbl
            // 
            this.SignUpLnkLbl.AutoSize = true;
            this.SignUpLnkLbl.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLnkLbl.Location = new System.Drawing.Point(24, 616);
            this.SignUpLnkLbl.Name = "SignUpLnkLbl";
            this.SignUpLnkLbl.Size = new System.Drawing.Size(143, 27);
            this.SignUpLnkLbl.TabIndex = 25;
            this.SignUpLnkLbl.TabStop = true;
            this.SignUpLnkLbl.Text = "Sign Up Here";
            this.SignUpLnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLnkLbl_LinkClicked);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(222, 399);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(121, 51);
            this.LoginBtn.TabIndex = 26;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(638, 652);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.SignUpLnkLbl);
            this.Controls.Add(this.LPPasswordLbl);
            this.Controls.Add(this.LPPasswordTXTBX);
            this.Controls.Add(this.LPEmailTXTBX);
            this.Controls.Add(this.LPEmailLbl);
            this.Controls.Add(this.BudgetFinancialsLableLP);
            this.DoubleBuffered = true;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BudgetFinancialsLableLP;
        private System.Windows.Forms.Label LPEmailLbl;
        private System.Windows.Forms.TextBox LPEmailTXTBX;
        private System.Windows.Forms.TextBox LPPasswordTXTBX;
        private System.Windows.Forms.Label LPPasswordLbl;
        private System.Windows.Forms.LinkLabel SignUpLnkLbl;
        private System.Windows.Forms.Button LoginBtn;
    }
}