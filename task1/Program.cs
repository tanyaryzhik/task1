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
            Worker firstWorker = new Worker();
            Worker secondWorker = new Worker();
            firstWorker.name = "John";
            firstWorker.age = 25;
            firstWorker.salary = 1000;
            secondWorker.name = "Basil";
            secondWorker.age = 26;
            secondWorker.salary = 2000;
            Console.WriteLine(firstWorker.age + secondWorker.age);
            Console.WriteLine(firstWorker.salary + secondWorker.salary);


        }
    }
}
