using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Bank
{
    public interface IInterestChargeable
    {
        void SetInterestRate(decimal interestRate);
        void ChargeInterest();
    }
}
