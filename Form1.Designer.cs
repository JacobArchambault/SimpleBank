namespace SimpleBank
{
    partial class BankForm
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
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.initialBalanceLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.initialBalanceTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            this.depositLabel = new System.Windows.Forms.Label();
            this.withdrawLabel = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawalButton = new System.Windows.Forms.Button();
            this.balanceAmountLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Location = new System.Drawing.Point(15, 44);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(116, 20);
            this.accountNameLabel.TabIndex = 0;
            this.accountNameLabel.Text = "Account name:";
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(240, 47);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(130, 20);
            this.accountNumberLabel.TabIndex = 1;
            this.accountNumberLabel.Text = "Account number:";
            // 
            // initialBalanceLabel
            // 
            this.initialBalanceLabel.AutoSize = true;
            this.initialBalanceLabel.Location = new System.Drawing.Point(18, 79);
            this.initialBalanceLabel.Name = "initialBalanceLabel";
            this.initialBalanceLabel.Size = new System.Drawing.Size(110, 20);
            this.initialBalanceLabel.TabIndex = 2;
            this.initialBalanceLabel.Text = "Initial balance:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 15);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(88, 20);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(240, 15);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(88, 20);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last name:";
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Location = new System.Drawing.Point(134, 44);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.accountNameTextBox.TabIndex = 6;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(376, 44);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.accountNumberTextBox.TabIndex = 7;
            // 
            // initialBalanceTextBox
            // 
            this.initialBalanceTextBox.Location = new System.Drawing.Point(134, 76);
            this.initialBalanceTextBox.Name = "initialBalanceTextBox";
            this.initialBalanceTextBox.Size = new System.Drawing.Size(100, 26);
            this.initialBalanceTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(134, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(376, 9);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(347, 117);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(170, 34);
            this.createAccountButton.TabIndex = 12;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(240, 79);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 20);
            this.warningLabel.TabIndex = 13;
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Location = new System.Drawing.Point(18, 162);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(126, 20);
            this.depositLabel.TabIndex = 14;
            this.depositLabel.Text = "Deposit amount:";
            this.depositLabel.Visible = false;
            // 
            // withdrawLabel
            // 
            this.withdrawLabel.AutoSize = true;
            this.withdrawLabel.Location = new System.Drawing.Point(18, 216);
            this.withdrawLabel.Name = "withdrawLabel";
            this.withdrawLabel.Size = new System.Drawing.Size(149, 20);
            this.withdrawLabel.TabIndex = 15;
            this.withdrawLabel.Text = "Withdrawal amount:";
            this.withdrawLabel.Visible = false;
            // 
            // depositTextBox
            // 
            this.depositTextBox.Enabled = false;
            this.depositTextBox.Location = new System.Drawing.Point(173, 159);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 26);
            this.depositTextBox.TabIndex = 16;
            this.depositTextBox.Visible = false;
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Enabled = false;
            this.withdrawTextBox.Location = new System.Drawing.Point(173, 213);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(100, 26);
            this.withdrawTextBox.TabIndex = 17;
            this.withdrawTextBox.Visible = false;
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Location = new System.Drawing.Point(18, 290);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(126, 20);
            this.currentBalanceLabel.TabIndex = 18;
            this.currentBalanceLabel.Text = "Current balance:";
            this.currentBalanceLabel.Visible = false;
            // 
            // depositButton
            // 
            this.depositButton.Enabled = false;
            this.depositButton.Location = new System.Drawing.Point(347, 157);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(170, 34);
            this.depositButton.TabIndex = 20;
            this.depositButton.Text = "Make a deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Visible = false;
            this.depositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // withdrawalButton
            // 
            this.withdrawalButton.Enabled = false;
            this.withdrawalButton.Location = new System.Drawing.Point(347, 209);
            this.withdrawalButton.Name = "withdrawalButton";
            this.withdrawalButton.Size = new System.Drawing.Size(170, 34);
            this.withdrawalButton.TabIndex = 21;
            this.withdrawalButton.Text = "Make a withdrawal";
            this.withdrawalButton.UseVisualStyleBackColor = true;
            this.withdrawalButton.Visible = false;
            this.withdrawalButton.Click += new System.EventHandler(this.WithdrawalButton_Click);
            // 
            // balanceAmountLabel
            // 
            this.balanceAmountLabel.Location = new System.Drawing.Point(173, 290);
            this.balanceAmountLabel.Name = "balanceAmountLabel";
            this.balanceAmountLabel.Size = new System.Drawing.Size(100, 26);
            this.balanceAmountLabel.TabIndex = 22;
            this.balanceAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.balanceAmountLabel.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(347, 289);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(170, 34);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Clear fields";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Visible = false;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.balanceAmountLabel);
            this.Controls.Add(this.withdrawalButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.currentBalanceLabel);
            this.Controls.Add(this.withdrawTextBox);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.withdrawLabel);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.initialBalanceTextBox);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.initialBalanceLabel);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.accountNameLabel);
            this.Name = "BankForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label initialBalanceLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox initialBalanceTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label depositLabel;
        private System.Windows.Forms.Label withdrawLabel;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawalButton;
        private System.Windows.Forms.Label balanceAmountLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

