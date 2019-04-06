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
            //Console.WriteLine("Input radius");
            //string radiusString = Console.ReadLine();
            //int.TryParse(radiusString, out int radius);
            //Console.WriteLine($"The square of the round is {Program.PerformCalculation(radius)}");
            //Console.ReadLine();

            ////task1
            //int uberflu;
            //int _Identifier;
            //int \u006fIdentifier;
            //int myVar;
            //int myVariab1le;

            ////task2
            //double pi = 3.141592653;
            //double e = 2.7182818284590452;
            //Console.WriteLine($"Pi: {pi}");
            //Console.WriteLine($"e: {e}");

            ////task3
            //string str1 = "\nмоя строка";
            //string str2 = "\tмоя строка";
            //string str3 = "\aмоя строка";
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(GetHouresFromSeconds(2659847));
            //Console.WriteLine(IsNumberBetweenGiven());
            IsNumberOddAndThreeDigit();
            Console.ReadLine();
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }

        public static int GetHouresFromSeconds(int seconds)
        {
            int hours = seconds/3600;
            return hours;
        }

        public static bool IsNumberBetweenGiven()
        {
            //
            // Input three numbers.
            //
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if ((b < a && b > c) || (b > a && b < c))
                return true;
            else
                return false;
        }

        public static void IsNumberOddAndThreeDigit()
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%2 != 0)
            {
                if ((number / 100 != 0) && (number / 1000 == 0))
                    {
                    Console.WriteLine($"Number {number} is odd and threedigit");
                }
            }
            else
                Console.WriteLine($"Number {number} isn't odd and threedigit");
        }
    }
}
