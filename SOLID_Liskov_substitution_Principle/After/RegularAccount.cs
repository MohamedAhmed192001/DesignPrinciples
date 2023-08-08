using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Liskov_substitution_Principle.After
{
    internal abstract class RegularAccount : Account
    {
        public RegularAccount(string name, int balance) : base(name, balance)
        {
        }

        public abstract void Withdraw(decimal amount);
    }
}
