using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oops.Interface
{
    interface IBankAccount
    {
        bool DepositAmount(decimal amount);
        bool WithdrawaAmount(decimal amount);
        decimal CheckBalance();
    }
}
