using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            PerformValidation();
        }

        internal void PerformValidation()
        {
            RequireFullName();
            EnsureInputIsNumeric(accountNumberTextBox, "Account number");
            EnsureInputIsNumeric(initialBalanceTextBox, "Initial balance");
            CheckForEmptyTextBoxes();
        }
        internal void CheckForEmptyTextBoxes()
        {
            // check for empty textboxes.
            IEnumerable<TextBox> textBoxes = Controls.OfType<TextBox>();
            foreach (TextBox t in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(t.Text))
                {
                    warningLabel.Text = "All fields must be filled out";
                }
            }

        }
        internal void RequireFullName()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                warningLabel.Text = "First name is required";
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                warningLabel.Text = "Last name is required";
            }
            else
            {
                warningLabel.Text = "";
            }
            
        }
        internal void EnsureInputIsNumeric(TextBox textBox, string warningStringSubject) 
        {
            try
            {
                decimal.Parse(textBox.Text);
            }
            catch
            {
                warningLabel.Text = $"{warningStringSubject} must be a decimal";
            }
        }

    }
}
