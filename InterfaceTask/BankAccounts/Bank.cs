using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.BankAccounts
{
    public class Bank
    {
        public List<Account> Accounts { get; set; }

        public void CreateAccount(string owner, decimal balance, int id, string accountType)
        {
            Account account = null;
            switch (accountType)
            {
                case "C":
                    account = new CreditCard(owner, balance, id);
                    break;
                case "D":
                    account = new Deposit(owner, balance, id);
                    break;
                case "S":
                    account = new Savings(owner, balance, id);
                    break;
            }
            Accounts.Add(account);
        }

        public void PutAmount(decimal amount, int id)
        {
            foreach (var item in Accounts)
            {
                if (item.Id == id)
                    item.CurrentBalance += amount;
            }
        }

        public void TakeAmount(decimal amount, int id)
        {
            foreach (var item in Accounts)
            {
                if (item.Id == id)
                    item.CurrentBalance -= amount;
            }
        }

        public void UpdateBalanceWithInterest(int id)
        {
            foreach (var item in Accounts)
            {
                if (item.Id == id)
                {
                    if (item is IInterestCountable account)
                    {
                        account.UpdateBalanceWithInterest();
                    }
                    //if (item is Deposit depositAccount)
                    //{
                    //    depositAccount = (Deposit)item;
                    //    depositAccount.CurrentBalance += depositAccount.InterestRate * depositAccount.CurrentBalance;
                    //}
                }
            }
        }

        public void SetInterestRate(int id, decimal interestRate)
        {
            foreach (var item in Accounts)
            {
                if (item.Id == id)
                {
                    if (item is CreditCard creditAccount)
                    {
                        creditAccount = (CreditCard)item;
                        creditAccount.InterestRate = interestRate;
                    }
                    if (item is Deposit depositAccount)
                    {
                        depositAccount = (Deposit)item;
                        depositAccount.InterestRate = interestRate;
                    }
                }
            }
        }

        public decimal GetBalance(int id)
        {
            decimal balance = 0m;
            foreach (var item in Accounts)
            {
                if (item.Id == id)
                    balance = item.CurrentBalance;
            }
            return balance;
        }

        public void CloseAccount(int id)
        {
            foreach (var item in Accounts)
            {
                if (item.Id == id)
                    item.CurrentBalance = 0m;
            }
        }

    }
}
