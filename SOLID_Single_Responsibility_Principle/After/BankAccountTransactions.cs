using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SOLID_Single_Responsibility_Principle.After
{
    internal class BankAccountTransactions
    {
        public void Deposit(BankAccountAttributes attributes, decimal amount) 
        {
            var transactionMessage = "";

             // handle deposit
            if (amount > 0)
            {
                attributes.Balance += amount;

                transactionMessage =
                    $"OK Deposit {amount.ToString("C2")}" +
                    $", current balance {attributes.Balance.ToString("C2")}";
            }

            // mock process for sending email
            EmailClient emailClient = new EmailClient();
            emailClient.Send(attributes,transactionMessage,DateTime.Now);
        }
        public void withDraw(BankAccountAttributes attributes, decimal amount) 
        {
            var transactionMessage = "";

            // handle withdraw
            
            if (attributes.Balance < Math.Abs(amount))
            {
                transactionMessage =
                $"OVERDRAFT when trying to withdraw " +
                $"{Math.Abs(amount).ToString("C2")}," +
                $" current balance {attributes.Balance.ToString("C2")}";
            }
            else
            {
                attributes.Balance -= amount;
                transactionMessage =
                    $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                    $", current balance {attributes.Balance.ToString("C2")}";
            }
            

            // mock process for sending email
            EmailClient emailClient = new EmailClient();
            emailClient.Send(attributes, transactionMessage, DateTime.Now);
        }
    }
}
