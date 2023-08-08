using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Liskov_substitution_Principle.Before
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

        public override void Withdraw(decimal amount)
        {
            throw new NotSupportedException("You can not withdraw with fixed deposit account!!");
        }
    }
}
