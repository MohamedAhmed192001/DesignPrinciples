using SOLID_Liskov_substitution_Principle.After;
//using SOLID_Liskov_substitution_Principle.Before;

using System;

namespace DesignPrinciples.SOLID_Liskov_substitution_Principle
{

    class prgram
    {
        static void Main(string[] args)
        {
            var account = new FixedDepositAccount("Mohamed",10000);
            account.Deposit(3000);

        }
    }
}
