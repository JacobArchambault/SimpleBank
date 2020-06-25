﻿namespace SimpleBank
{
    partial class bankForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Create account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // bankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.button1);
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
            this.Name = "bankForm";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label warningLabel;
    }
}
