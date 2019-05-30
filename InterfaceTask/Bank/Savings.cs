using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Bank
{
    public class Savings : Account, IBalanceAccessible
    {
        public Savings(string owner, decimal balance)
            : base(owner, balance)
        {

        }
        
        public void PutMoneyIn(decimal amount)
        {
            this.CurrentBalance = this.CurrentBalance + amount;
        }

        public void TakeMoneyOut(decimal amount)
        {
            this.CurrentBalance = this.CurrentBalance - amount;
        }
    }
}
