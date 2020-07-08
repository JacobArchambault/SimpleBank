using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    // A Class containing information for a customer for a bank.
    internal class Customer
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string AccountName => $"{FirstName} {LastName}";
        internal int AccountNumber { get; set; }
        internal decimal AccountBalance { get; set; }
        // adds the passed in amount to the customer's account balance.
        internal void Deposit(decimal amount)
        {
            AccountBalance += amount;
        }
        // Subtracts the passed in amount from the customer's account balance.
        internal void Withdraw(decimal amount)
        {
            AccountBalance -= amount;
        }
    }
}
