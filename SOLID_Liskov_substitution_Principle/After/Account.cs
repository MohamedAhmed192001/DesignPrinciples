using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Liskov_substitution_Principle.After
{
    internal abstract class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        protected Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }
        public abstract void Deposit(decimal amount);
        

    }

}
