using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Count));
            thread.Start();
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("First thread: " + i * i);
                Thread.Sleep(100);
            }
        }

        static void Count()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Second thread: " + i * i);
                Thread.Sleep(100);
            }
        }
    }
}
