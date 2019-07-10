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
            var employees = Employee.GetEmployees();

            Console.WriteLine("In alphabetical order:");
            var alphabeticalOrderEmployees = employees.OrderBy(e => e.LastName);
            Display(alphabeticalOrderEmployees);

            Console.WriteLine("Older then 30:");
            var olderEmployees = employees.Where(e => e.Age > 30);
            Display(olderEmployees);

            Console.WriteLine("Men:");
            var maleEmployees = employees.Where(e => e.Gender == "M");
            Display(maleEmployees);

            Console.WriteLine("Women:");
            var femaleEmployees = employees.Where(e => e.Gender == "F");
            Display(femaleEmployees);

            Console.WriteLine("Employees:");
            var employeesNames = employees.Select(e => e.FirstName + " " + e.LastName);
            foreach (var item in employeesNames)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Woman with name from 'O' and older 20:");
            var filteredEmployees = employees.Where(e => e.Gender == "F" && e.FirstName.StartsWith("O") && e.Age > 20);
            foreach (var item in filteredEmployees)
            {
                Console.WriteLine(item.LastName);
            }
            //
            //Grouping.
            //
            var companyGroups = from employee in employees
                                group employee by employee.Company;
            foreach (IGrouping<string, Employee> g in companyGroups)
            {
                Console.WriteLine(g.Key);
                foreach (var item in g)
                {
                    Console.WriteLine(item.LastName);
                }
                Console.WriteLine($"{g.Count()} employees");
            }

            Console.WriteLine("Second way");
            var companyGroupsSecond = employees.GroupBy(e => e.Company).Select(g => new { Name = g.Key, Count = g.Count() });
            foreach (var item in companyGroupsSecond)
            {
                Console.WriteLine($"{item.Name} has {item.Count} employees.");
            }

            Console.WriteLine($"The first employee is {employees.First().LastName}");
            Console.WriteLine($"The last employee is {employees.Last().LastName}");
            Console.WriteLine($"The first employee older than 25 is {employees.Where(e => e.Age > 25).First().LastName}");
            var pupil = employees.Where(e => e.FirstName == "Oleg").Select(p => new { FirstName = p.FirstName,LastName = p.LastName, School = 154});
        }

        private static void Display(IEnumerable<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.LastName} {item.FirstName}");
            }
        }
    }
}
