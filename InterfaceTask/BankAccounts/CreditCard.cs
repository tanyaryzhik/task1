using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.BankAccounts
{
    public class CreditCard : Account, IInterestCountable
    {
        public decimal InterestRate { get; set; }

        public CreditCard(string owner, decimal balance, int id)
            : base(owner, balance, id)
        {
            this.InterestRate = 0.12m;
        }

        public void SetInterestRate(decimal interestRate)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalanceWithInterest()
        {
            this.CurrentBalance += this.CurrentBalance * this.InterestRate;
        }
    }
}
