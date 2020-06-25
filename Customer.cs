using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank
{
    internal class Customer
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string AccountName { get; set; }
        internal int AccountNumber { get; set; }
        internal decimal AccountBalance { get; set; }
    }
}
