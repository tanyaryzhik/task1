using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Employee : User
    {
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
            }
        }

        public Employee(string name, int age, decimal salary) : base(name, age)
        {
            Salary = salary;
        }
    }
}
