using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Worker firstWorker = new Worker("John", 25, 1000);
            //Worker secondWorker = new Worker("Vasya", 26, 2000);
            Employee firstEmployee = new Employee("John", 25, 1000);
            Employee secondEmployee = new Employee("Vasia", 26, 2000);
            Driver driver = new Driver("Fill", 25, 1000, 5, Category.A);
            Console.WriteLine(firstEmployee.Salary + secondEmployee.Salary);
            Console.WriteLine(firstEmployee.Age + secondEmployee.Age);
        }
    }
}
