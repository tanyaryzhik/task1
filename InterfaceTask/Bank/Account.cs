using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Bank
{
    public class Account
    {
        private string owner;

        public string Owner
        {
            get => owner;
            set
            {
                owner = value;
            }
        }
        private decimal currentBalance;

        public decimal CurrentBalance
        {
            get => currentBalance;
            set
            {
                currentBalance = value;
            }
        }

        public virtual decimal InterestRate { get; set; }

        public virtual decimal Interest { get; set; }

        public Account(string owner, decimal balance)
        {
            this.Owner = owner;
            this.CurrentBalance = balance;
        }

        public string GetOwner() => Owner;

        public decimal GetCurrentBalance() => CurrentBalance;

        public decimal CloseAccount()
        {
            decimal amount = GetCurrentBalance();
            this.CurrentBalance = 0m;
            return amount;
        }
    }
}
