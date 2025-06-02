using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
        }

        public BankAccount(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                Console.Write("Initial balance cannot be negative");
            }
            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount should be positive");
            }
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Deposit amount should be positive");
            }
            if (balance - amount < 0)
            {
                throw new ArgumentException("Insufficient Balance");
            }
            balance -= amount;
        }

    }
}
