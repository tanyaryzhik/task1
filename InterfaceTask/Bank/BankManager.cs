using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Bank
{
    public class BankManager
    {
        public void Execute()
        {
            Account[] accounts = new Account[5];
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = CreateAccount();
            }

            foreach (var item in accounts)
            {
                Console.WriteLine($"Owner: {item.Owner}, current balance: {item.CurrentBalance}, interest: {item.Interest}");
            }
        }

        private Account CreateAccount()
        {
            string accountType = GetAccountType();
            string owner = string.Empty;
            decimal balance = 0m;
            while (true)
            {
                Console.WriteLine("Enter Owner");
                owner = Console.ReadLine();
                if (!string.IsNullOrEmpty(owner))
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Enter balance");
                if (Decimal.TryParse(Console.ReadLine(), out balance))
                    break;
            }
            Account account = null;
            switch (accountType)
            {
                case "C":
                    account = new CreditCard(owner, balance);
                    account.Interest = account.CurrentBalance * account.InterestRate;
                    break;
                case "D":
                    account = new Deposit(owner, balance);
                    account.Interest = account.CurrentBalance * account.InterestRate;
                    break;
                case "S":
                    account = new Savings(owner, balance);
                    break;
            }
            return account;
        }

        //private Account GetAccount(string accountType, string owner, decimal balance)
        //{
        //    Account account = new Account(owner, balance);
        //    switch (accountType)
        //    {
        //        case "C":
        //            CreditCard creditCard = account as CreditCard;
        //            creditCard.Interest = 0.12m;
        //            break;
        //        case "D":
        //            Deposit deposit = account as Deposit;
        //            deposit.Interest = 0.25m;
        //            break;
        //        case "S":
        //            Savings savings = account as Savings;
        //            break;
        //    }
        //    return account;
        //}

        private string GetAccountType()
        {
            string result = string.Empty;
            Console.WriteLine("Enter type of a bank account: Credit(C), Deposit(D) or Savings(S)");
            while (true)
            {
                result = Console.ReadLine();
                if (result == "C" || result == "D" || result == "S")
                    break;
                else
                    Console.WriteLine("Write C, D or S");
            }
            return result;
        }
    }
}
