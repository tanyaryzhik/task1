using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJuly7
{
    public class Employee
    {
        public Int32 Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public DateTime BirthDate { get; set; }


        public static IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
               new Employee{Id = 1, FirstName = "Eddard", LastName = "Stark", Gender = "M", BirthDate = new DateTime(1950,1,25)},
               new Employee{Id = 2, FirstName = "Jon", LastName = "Snow", Gender = "M", BirthDate = new DateTime(1975,5,10)},
               new Employee{Id = 3, FirstName = "Tyron", LastName = "Lannister", Gender = "M", BirthDate = new DateTime(1967,8,12)},
               new Employee{Id = 4, FirstName = "Cersei", LastName = "Lannister", Gender = "F", BirthDate = new DateTime(1960,12,6)}
            };
        }
    }
}
