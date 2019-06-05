using InterfaceTask.BankAccounts;
using InterfaceTask.Switcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Manager().Manage();
            new BankManager().Execute();
        }
    }
}
