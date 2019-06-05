using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.BankAccounts
{
    public class Savings : Account, IBalanceAccessible
    {
        public Savings(string owner, decimal balance, int id)
            : base(owner, balance, id)
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
