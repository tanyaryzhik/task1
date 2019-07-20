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
            int n = 15;
            Thread thread = new Thread(new ParameterizedThreadStart(Count));
            thread.Start(n);
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("First thread: " + i * n);
                Thread.Sleep(100);
            }
        }

        static void Count(object x)
        {
            int n = (int)x;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Second thread: " + i * n);
                Thread.Sleep(100);
            }
        }
    }
}
