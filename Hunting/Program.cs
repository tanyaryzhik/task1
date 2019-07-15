using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hunting
{
    class Program
    {
        static void Main(string[] args)
        {
            Hare hare = new Hare();
            Hunter hunter = new Hunter(hare);
            for (int i = 0; i < 15; i++)
            {
                hare.Move();
                Thread.Sleep(100);
            }
        }
    }
}
