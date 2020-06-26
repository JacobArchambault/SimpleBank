using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank
{
    public partial class bankForm : Form
    {
        #region Global fields
        private Customer _customer;
        #endregion
        #region Constructor
        public bankForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Event handlers
        private void button1_Click(object sender, EventArgs e)
        {
            warningLabel.Text = "";
            if (AllInputsAreValid()) 
            {
                _customer = CreateCustomer();
                LockAccountCreationControls(new List<TextBox>
                {
                    firstNameTextBox,
                    lastNameTextBox,
                    accountNameTextBox,
                    accountNumberTextBox,
                    initialBalanceTextBox 
                });
                EnableDepositAndWithDrawControls();

            };
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }
        #endregion

        #region Helper methods
        private void EnableDepositAndWithDrawControls()
        {
            throw new NotImplementedException();
        }

        private void LockAccountCreationControls(List<TextBox> textBoxes)
        {
            textBoxes.ForEach(textBox => textBox.ReadOnly = true);
            createAccountButton.Enabled = false;
        }

        private Customer CreateCustomer()
        {
            return new Customer
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                AccountName = accountNameTextBox.Text,
                AccountNumber = int.Parse(accountNumberTextBox.Text),
                AccountBalance = decimal.Parse(initialBalanceTextBox.Text)
            };
        }

        private bool AllInputsAreValid()
        {
            return FieldIsFilled(firstNameTextBox, "First name") &&
            FieldIsFilled(lastNameTextBox, "Last name") &&
            FieldIsFilled(accountNameTextBox, "Account name") &&
            InputIsNumeric(accountNumberTextBox, "Account number", "whole number") &&
            InputIsNumeric(initialBalanceTextBox, "Initial balance", "decimal");
        }
        private bool FieldIsFilled(TextBox textBox, string warningMessageSubject)
        {
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(textBox.Text);
            if (isNullOrWhiteSpace)
            {
                warningLabel.Text = $"{warningMessageSubject} is required";
            }
            return !isNullOrWhiteSpace;
        }
        private bool InputIsNumeric(TextBox textBox, string warningMessageSubject, string desiredNumericType) 
        {
            bool isDesiredNumericType = decimal.TryParse(textBox.Text, out _);
            if (!isDesiredNumericType)
            {
                warningLabel.Text = $"{warningMessageSubject} must be a {desiredNumericType}";
            }
            return isDesiredNumericType;
        }
        #endregion

    }
}
