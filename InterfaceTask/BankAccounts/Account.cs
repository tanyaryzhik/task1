using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.BankAccounts
{
    public class Account
    {
        public string Owner { get; set; }
        
        public decimal CurrentBalance { get; set; }

        public int Id { get; set; }

        public Account(string owner, decimal balance, int id)
        {
            this.Owner = owner;
            this.CurrentBalance = balance;
            this.Id = id;
        }

        public string GetOwner() => this.Owner;

        public decimal GetCurrentBalance() => CurrentBalance;

        public decimal CloseAccount()
        {
            decimal amount = GetCurrentBalance();
            this.CurrentBalance = 0m;
            return amount;
        }
    }
}
