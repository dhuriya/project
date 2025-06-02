using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Encapsulation
{
    class EncapsulationBank
    {
        private double _Amount;
        public double Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Please pass a positive value");
                }
                else
                {
                    _Amount = value;
                }
            }

        }
        public long AccountNumber;
        public string Name;
        private int Balance;
        public int GetBalance()
        {
            return Balance;
        }
        public void SetBalance(int balance)
        {
            this.Balance = balance;
        }
        public void WithdrawAmount()
        {
        }
        public void Deposti()
        {
        }
    }
}
