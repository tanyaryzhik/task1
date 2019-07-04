﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.BankAccounts
{
    public interface IBalanceAccessible
    {
        void PutMoneyIn(decimal amount);

        void TakeMoneyOut(decimal amount);
    }
}