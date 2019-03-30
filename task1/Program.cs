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
            Console.WriteLine("Input radius");
            string radiusString = Console.ReadLine();
            int.TryParse(radiusString, out int radius);
            Console.WriteLine($"The square of the round is {Program.PerformCalculation(radius)}");
            Console.ReadLine();

            //task1
            int uberflu;
            int _Identifier;
            int \u006fIdentifier;
            int myVar;
            int myVariab1le;

        }
        public static decimal PerformCalculation(int r)
        {
            const decimal  Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }
    }
}
