using SOLID_Liskov_substitution_Principle.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Liskov_substitution_Principle.After
{
    internal class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string name, int balance) : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"You deposit {amount}, \n Now your Balance is {Balance}");

        }

    }
}
