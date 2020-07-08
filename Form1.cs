using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBank
{
    public partial class BankForm : Form
    {
        #region Global fields
        private Customer _customer;
        #endregion

        #region Constructor
        public BankForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Event handlers
        // If all textbox inputs are valid, then on clicking the 'Create Account' button, this method:
        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            warningLabel.Text = "";
            if (AllInputsAreValid()) 
            {
                // creates a customer object;
                _customer = CreateCustomer();
                //locks the first name, last name, account name, account number, and initial balance textboxes;
                LockAccountCreationControls(new List<TextBox>
                {
                    firstNameTextBox,
                    lastNameTextBox,
                    accountNameTextBox,
                    accountNumberTextBox,
                    initialBalanceTextBox 
                });
                // enables and shows the controls associated with depositing and withdrawing funds;
                EnableAndShowControls(new List<Control> { depositLabel, depositTextBox, depositButton, withdrawLabel, withdrawTextBox, withdrawalButton, currentBalanceLabel, resetButton});
                // assigns the decimal stored in the customer's AccountBalance property to the balance amount label's text, displaying it as a currency,
                balanceAmountLabel.Text = _customer.AccountBalance.ToString("C", CultureInfo.CurrentCulture);
                // and makes the balance amount label object visible.
                balanceAmountLabel.Visible = true;
            };
        }
        private void DepositButton_Click(object sender, EventArgs e)
        {
            // On clicking the deposit buton, deposit the amount from the deposit text box into the customer's balance...
            if (decimal.TryParse(depositTextBox.Text, out decimal depositAmount))
            {
                _customer.Deposit(depositAmount);
                // ...and display that balance on the balance amount label as a string
                balanceAmountLabel.Text = _customer.AccountBalance.ToString("C", CultureInfo.CurrentCulture);
                // ... and reset the warning label text to an empty string.
                warningLabel.Text = "";
            }
            else
            {
                warningLabel.Text = "Deposit amount must be a decimal";
            }
        }

        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            // On clicking the deposit buton, deposit the amount from the deposit text box into the customer's balance...
            if (decimal.TryParse(withdrawTextBox.Text, out decimal withdrawAmount))
            {
                _customer.Deposit(withdrawAmount);
                // ...and display that balance on the balance amount label as a string
                balanceAmountLabel.Text = _customer.AccountBalance.ToString("C", CultureInfo.CurrentCulture);
                // ... and reset the warning label text to an empty string.
                warningLabel.Text = "";
            }
            else
            {
                warningLabel.Text = "Withdrawal amount must be a decimal";
            }
        }
        // reset the values in the deposit and withdraw fields.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            depositTextBox.Text = "0";
            withdrawTextBox.Text = "0";
            warningLabel.Text = "";
        }
        #endregion

        #region Helper methods
        private void EnableAndShowControls(List<Control> controls)
        {
            // Set each control in a list of controls passed in to be both enabled and visible.
            controls.ForEach(c => {c.Enabled = true; c.Visible = true; });
        }

        private void LockAccountCreationControls(List<TextBox> textBoxes)
        {
            // Set each textbox in a list of textboxes to readonly.
            textBoxes.ForEach(textBox => textBox.ReadOnly = true);
            // disable the create account button.
            createAccountButton.Enabled = false;
        }

        private Customer CreateCustomer()
        {
            // Create a new customer object, obtaining its first name, last name, account name, account number, and account balance fields from its associated textboxes.
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
            // Check whether all inputs are valid by checking whether the firstname, last name, and account name fields are filled, ensuring that the account number textbox has a numeric input, and the initial balance textbox has an input that may be parsed as a decimal.
            return FieldIsFilled(firstNameTextBox, "First name") &&
            FieldIsFilled(lastNameTextBox, "Last name") &&
            FieldIsFilled(accountNameTextBox, "Account name") &&
            InputIsNumeric(accountNumberTextBox, "Account number", "whole number") &&
            InputIsNumeric(initialBalanceTextBox, "Initial balance", "decimal");
        }
        private bool FieldIsFilled(TextBox textBox, string warningMessageSubject)
        {
            // Check whether a given textbox field is filled by checking whether its text is null or whitespace. If it is, write a warning message with the passed in string parameter. Return true if the input is neither null nor whitespace, and false otherwise.
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(textBox.Text);
            if (isNullOrWhiteSpace)
            {
                warningLabel.Text = $"{warningMessageSubject} is required";
            }
            return !isNullOrWhiteSpace;
        }
        private bool InputIsNumeric(TextBox textBox, string warningMessageSubject, string desiredNumericType) 
        {
            // check whether an input is the desired numeric type by trying to parse it. If it can be parse, return true. If it can't return false and write a message to the user.
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
