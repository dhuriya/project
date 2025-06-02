using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Abstraction
{
    public interface IBank
    {
        //Example to Implement Abstraction Principle in C# using Interface:

        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();

    }
}
