using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJuly7
{
    public class EmployeeFilter
    {
        public delegate bool EmpFilter(Employee employee);
        public static IEnumerable<Employee> Filter(IEnumerable<Employee> employees, EmpFilter filter)
        {
            var filteredEmployees = new List<Employee>();
            foreach (var item in employees)
            {
                if (filter(item))
                    filteredEmployees.Add(item);
            }
            return filteredEmployees;
        }
    }
}
