using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Interface
{
    public class SavingAccount : IBankAccount
    {
        private decimal Balance = 0;
        private readonly decimal PerDayWithdrawaLimit = 10000;
        private decimal TodayWithdrawal = 0;

        public bool DepositAmount(decimal Amount)
        {
            Balance = Balance + Amount;
            Console.WriteLine("You have Deposited : "+Amount+"");
            Console.WriteLine("Your Account Balance : "+Balance+"");
            return true;
        }

        public bool WithdrawaAmount(decimal Amount)
        {
            if (Balance < Amount)
            {
                Console.WriteLine("You have Insufficient Balance!");
            }
            else if (TodayWithdrawal + Amount > PerDayWithdrawaLimit)
            {
                Console.WriteLine("Withdrawal attempt failed!");
            }
            else
            {
                Balance = Balance - Amount;
                TodayWithdrawal = TodayWithdrawal + Amount;
                Console.WriteLine("You have Successfully Withdrawa : "+Amount+"");
                Console.WriteLine("Your Account Balance : "+Balance+"");
                
            }
            return true;
        }
        public decimal CheckBalance()
        {
            return Balance;
        }
    }
}
