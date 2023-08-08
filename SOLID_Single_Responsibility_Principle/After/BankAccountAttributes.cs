using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Single_Responsibility_Principle.After
{
    internal class BankAccountAttributes
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public BankAccountAttributes(string name, string email, decimal balance)
        {
            this.Name = name;
            this.Email = email;
            this.Balance = balance;
        }
    }
}
