using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Encapsulation
{
     public class DigitalWallet
    {
         private decimal balance;
         private string walletPassword;
         private List<string> transactionLog = new List<string>();

         public DigitalWallet(string initialPassword)
         {
             balance = 0;
             walletPassword = initialPassword;
         }
         private void LogTransaction(string transactionDeatails)
         {
             transactionLog.Add(transactionDeatails);
         }

         public void Deposit(decimal amount)
         {
             if (amount < 0)
             {
                 throw new ArgumentException("Deposit amount should be positive....");
             }
             else
             {
                 balance += amount;
                 LogTransaction("Deposited " + amount + " Current balance " + balance);
             }
         }

         public bool Withdrow(decimal amount, string password)
         {
             if (amount < 0)
             {
                 throw new AggregateException("Withdrow amount should be positive...");
             }
             else if(walletPassword != password)
             {
                 LogTransaction("Failed withdrawal attempt of " + amount + "Incorrect..");
                 return false;
             }
             else if (balance - amount < 0)
             {
                 LogTransaction("Failed withdrawal attempt of " + amount + "Insufficient..");
                 return false;
             }
             else
             {
                 balance -= amount;
                 LogTransaction("Withdrawal amount " + amount + "Current balance "+ balance);
                 return true;
             }
         }
         public decimal CheckBalance(string password)
         {
             if (walletPassword == password)
             {
                 return balance;
             }
             else
             {
                 throw new UnauthorizedAccessException("Incorrect Password....");
             }
         }
         public List<string> GetTransactionLog(string password)
         {
             if (walletPassword == password)
             {
                 return new List<string>(transactionLog);  // Return a copy to maintain encapsulation.
             }
             else
             {
                 throw new UnauthorizedAccessException("Incorrect password.");
             }
         }
    }
}
