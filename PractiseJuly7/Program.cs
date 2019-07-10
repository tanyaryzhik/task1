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
            //foreach (var item in EmployeeFilter.Filter(Employee.GetEmployees(), filter => filter.LastName == "Lannister"))
            //{
            //    Console.WriteLine($"{item.FirstName}, {item.BirthDate.ToShortDateString()}");
            //}
            DeferedExample();
        }
        public static void DeferedExample()
        {
            var employees = Employee.GetEmployees().ToList();
            var maleEmployees = employees.Where(e => e.Gender == "M").ToList();
            Display(maleEmployees);
            employees.Add(new Employee { FirstName = "Rob", LastName = "Starck", Gender = "M" });
            Display(maleEmployees);
        }

        private static void Display(IEnumerable<Employee> maleEmployees)
        {
            foreach (var item in maleEmployees)
            {
                Console.WriteLine($"{item.FirstName}, {item.LastName}");
            }
        }
    }
}
