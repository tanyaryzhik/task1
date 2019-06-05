using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.BankAccounts
{
    public interface IInterestCountable
    {
        void SetInterestRate(decimal interestRate);

        void UpdateBalanceWithInterest();
    }
}
