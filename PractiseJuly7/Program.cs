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
            //DeferedExample();
            CollectionExample();
        }

        public static void CollectionExample()
        {
            Employee[] firstCollection = new Employee[] {
                new Employee { FirstName = "Tatiana", LastName = "Ryzhik", Age = 38, Gender = "F", Company = "ParkMe"},
               new Employee { FirstName = "Olga", LastName = "Pavlenko", Age = 36, Gender = "F", Company = "ParkMe"},
               new Employee { FirstName = "Helen", LastName = "Zub", Age = 20, Gender = "F", Company = "Max"},
               new Employee { FirstName = "Kirill", LastName = "Novikov", Age = 26, Gender = "M", Company = "ParkMe"},
            };
            Employee[] secondCollection = new Employee[] {
                new Employee { FirstName = "Helen", LastName = "Zub", Age = 20, Gender = "F", Company = "Max"},
               new Employee { FirstName = "Kirill", LastName = "Novikov", Age = 26, Gender = "M", Company = "ParkMe"},
               new Employee { FirstName = "Alex", LastName = "Matsegora", Age = 25, Gender = "M", Company = "Max"},
               new Employee { FirstName = "Oleg", LastName = "Reshetilo", Age = 26, Gender = "M", Company = "Admin"},
               new Employee { FirstName = "Valeriy", LastName = "Malinovskiy", Age = 22, Gender = "M", Company = "Here"},
            };

            var collectionWithDuplicates = firstCollection.Concat(secondCollection);
            Console.WriteLine("With duplicates:");
            Display(collectionWithDuplicates);

            var collectionWithoutDuplicates = firstCollection.Union(secondCollection);
            Console.WriteLine("Without duplicates:");
            Display(collectionWithoutDuplicates);

            var collectionIntersection = firstCollection.Intersect(secondCollection);
            Console.WriteLine("Employees in both collections (intersection):");
            Display(collectionIntersection);

            List<Employee> firstList = firstCollection.ToList();
            firstList.Add(new Employee { FirstName = "Jane", LastName = "Gladysheva", Age = 25, Gender = "F", Company = "Here" });
            Console.WriteLine("Employees of first collection plus one more:");
            Display(firstList);
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
            var pupil = employees.Where(e => e.FirstName == "Oleg").Select(p => new { FirstName = p.FirstName, LastName = p.LastName, School = 154 });
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
