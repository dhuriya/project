using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Abstraction
{
    public class AXIX : Abstract // : IBank
    {
        //public void BankTransfer()
        //{
        //    Console.WriteLine("AXIX Bank Bank Transfer");
        //}
        //public void CheckBalanace()
        //{
        //    Console.WriteLine("AXIX Bank Check Balance");
        //}
        //public void MiniStatement()
        //{
        //    Console.WriteLine("AXIX Bank Mini Statement");
        //}
        //public void ValidateCard()
        //{
        //    Console.WriteLine("AXIX Bank Validate Card");
        //}
        //public void WithdrawMoney()
        //{
        //    Console.WriteLine("AXIX Bank Withdraw Money");
        //}
        //Example to Implement Abstraction Principle in C# using Abstract Class and Abstract Methods:
        public override void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }
        public override void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balance");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }
        public override void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}
