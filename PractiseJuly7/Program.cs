using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJuly7
{
    class Program
    {
               static void Main(string[] args)
        {
            
            
            foreach (var item in EmployeeFilter.Filter(Employee.GetEmployees(), filter => filter.LastName == "Lannister"))
            {
                Console.WriteLine($"{item .FirstName}, {item.BirthDate.ToShortDateString()}");
            }
            
        }
    }
}
