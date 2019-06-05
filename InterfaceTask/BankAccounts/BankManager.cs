using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.BankAccounts
{
    public class BankManager
    {
        public Bank Bank { get; set; }

        public BankManager()
        {
            this.Bank = new Bank();
        }
        public void Execute()
        {
            //
            //Filling list of accounts.
            //
            Bank.Accounts = new List<Account>();
            int count = 1;
            string answer = string.Empty;
            while (true)
            {
                Console.WriteLine($"{count} account:");
                EnterAccountData();
                Console.WriteLine("Do you want to continue? Y/N");
                while (true)
                {
                    answer = Console.ReadLine();
                    if (answer == "Y" || answer == "N")
                        break;
                    else
                        Console.WriteLine("Write Y or N");
                }
                if (answer == "N")
                    break;
                count++;
            }

            //
            //Get balance of chosen account.
            //
            int currentId = 0;
            bool accountIsFound = false;
            Console.WriteLine("Enter Id of account you want to get balance of.");
            Int32.TryParse(Console.ReadLine(), out currentId);
            foreach (var item in Bank.Accounts)
            {
                if (item.Id == currentId)
                {
                    Console.WriteLine($"Account of {item.Owner} has balance {item.CurrentBalance}");
                    accountIsFound = true;
                }
            }
            if (accountIsFound == false)
            {
                Console.WriteLine("There's no account with this Id");
            }
        }

        public void EnterAccountData()
        {
            string accountType = GetAccountType();
            string owner = string.Empty;
            decimal balance = 0m;
            int id = 0;
            bool doesIdExist = false;
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
            while (true)
            {
                doesIdExist = false;
                Console.WriteLine("Enter Id");
                if (Int32.TryParse(Console.ReadLine(), out id))
                {
                    foreach (var item in Bank.Accounts)
                    {
                        if (id == item.Id)
                        {
                            Console.WriteLine("This Id is already exists. Enter another Id.");
                            doesIdExist = true;
                        }
                    }
                }
                if (doesIdExist == false)
                    break;
            }
            Bank.CreateAccount(owner, balance, id, accountType);
        }

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
