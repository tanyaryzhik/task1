using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJuly7
{
    public class Employee : IEquatable<Employee>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Company { get; set; }

        public static IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
               new Employee { FirstName = "Tatiana", LastName = "Ryzhik", Age = 38, Gender = "F", Company = "ParkMe"},
               new Employee { FirstName = "Olga", LastName = "Pavlenko", Age = 36, Gender = "F", Company = "ParkMe"},
               new Employee { FirstName = "Helen", LastName = "Zub", Age = 20, Gender = "F", Company = "Max"},
               new Employee { FirstName = "Kirill", LastName = "Novikov", Age = 26, Gender = "M", Company = "ParkMe"},
               new Employee { FirstName = "Alex", LastName = "Matsegora", Age = 25, Gender = "M", Company = "Max"},
               new Employee { FirstName = "Oleg", LastName = "Reshetilo", Age = 26, Gender = "M", Company = "Admin"},
               new Employee { FirstName = "Valeriy", LastName = "Malinovskiy", Age = 22, Gender = "M", Company = "Here"},
               new Employee { FirstName = "Anton", LastName = "Isaev", Age = 23, Gender = "M", Company = "Here"},
               new Employee { FirstName = "Jane", LastName = "Gladysheva", Age = 25, Gender = "F", Company = "Here"},
               new Employee { FirstName = "Artem", LastName = "Kravchenko", Age = 22, Gender = "M", Company = "ParkMe"},
            };
        }

        public bool Equals(Employee employee)
        {
            if (employee is null)
                return false;

            return this.FirstName == employee.FirstName
                && this.LastName == employee.LastName
                && this.Age == employee.Age
                && this.Gender == employee.Gender
                && this.Company == employee.Company;
        }

        public override bool Equals(object obj) => Equals(obj as Employee);

        public override int GetHashCode()
        {
            return Tuple.Create(this.FirstName, this.LastName, this.Age, this.Gender, this.Company).GetHashCode();
        }
    }
}
