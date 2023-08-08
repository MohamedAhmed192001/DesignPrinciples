using SOLID_Liskov_substitution_Principle.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Liskov_substitution_Principle.After
{
    internal class CheckingAccount : RegularAccount
    {
        public CheckingAccount(string name, int balance) : base(name, balance)
        {
        }

        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"You deposit {amount}, \n Now your Balance is {Balance}");
        }

        public override void Withdraw(decimal amount)
        {
            if(amount > 11000)
            {
                Console.WriteLine("You can not withdraw more than $1000");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"You Withdraw {amount}, \n Now, your Balance is {Balance}");

            }

        }
    }
}
