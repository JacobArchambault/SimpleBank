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
        public bankForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            warningLabel.Text = "";
            if (AllInputsAreValid()) 
            {
                CreateCustomer();
            };
        }

        private void CreateCustomer()
        {
            throw new NotImplementedException();
        }

        internal bool AllInputsAreValid()
        {
            return FieldIsFilled(firstNameTextBox, "First name") &&
            FieldIsFilled(lastNameTextBox, "Last name") &&
            FieldIsFilled(accountNameTextBox, "Account name") &&
            InputIsNumeric(accountNumberTextBox, "Account number") &&
            InputIsNumeric(initialBalanceTextBox, "Initial balance"); 
            }
        internal bool FieldIsFilled(TextBox textBox, string warningMessageSubject)
        {
            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(textBox.Text);
            if (isNullOrWhiteSpace)
            {
                warningLabel.Text = $"{warningMessageSubject} is required";
            }
            return isNullOrWhiteSpace;
        }
        internal bool InputIsNumeric(TextBox textBox, string warningMessageSubject) 
        {
            bool isDecimal = decimal.TryParse(textBox.Text, out _);
            if (!isDecimal)
            {
                warningLabel.Text = $"{warningMessageSubject} must be a decimal";
            }
            return isDecimal;
        }

    }
}
