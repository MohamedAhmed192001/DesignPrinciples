using SOLID_Single_Responsibility_Principle.After;
using SOLID_Single_Responsibility_Principle.Before;

namespace DesignPrinciples.SOLID_Single_Responsibility_Principle
{

    class prgram
    {

        static void Main(string[] args)
        {
            //TestWithoutSRP();
            TestWithSRP();

        }

        //private static void TestWithoutSRP()
        //{
        //    var bankAccount = new BankAccount("Mohamed", "Mohamed@gmail.com", 10000);
        //    bankAccount.MakeTransaction(500);
        //    bankAccount.MakeTransaction(-11000);

        //}

        private static void TestWithSRP()
        {
            var bankAccountAttributes = new BankAccountAttributes("Mohamed", "Mohamed@gmail.com", 10000);
            var bankAccountTransactions = new BankAccountTransactions();
            bankAccountTransactions.Deposit(bankAccountAttributes, 500);
            bankAccountTransactions.withDraw(bankAccountAttributes, 11000);

        }
    }
}
