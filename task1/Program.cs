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
            //IsNumberOddAndThreeDigit();
            //TaskFour();
            //Calculator();
            GetNumberArea();
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
            int hours = seconds / 3600;
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
            if (number % 2 != 0)
            {
                if ((number / 100 != 0) && (number / 1000 == 0))
                {
                    Console.WriteLine($"Number {number} is odd and threedigit");
                }
            }
            else
                Console.WriteLine($"Number {number} isn't odd and threedigit");
        }

        public static void TaskFour()
        {
            //
            // Different operations.
            //
            int x = 10;
            int y = 12;
            int z = 3;

            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * z;
            Console.WriteLine(x);
        }

        public static void Calculator()
        {
            Console.WriteLine("Input first number");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose operation +, -, *, /");
            string sign = Console.ReadLine();
            int result = 0;

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Cann't devide by zero");
                    }
                    else
                    { result = operand1 / operand2; }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{operand1} {sign} {operand2} = {result}");
        }

        public static void GetNumberArea()
        {
            Console.WriteLine("Input number from 0 to 100");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >=0 && number<=14)
            {
                Console.WriteLine($"{number} is in area [0-14]");
            }
            if (number >= 15 && number <=35)
            {
                Console.WriteLine($"{number} is in area [15-35]");
            }
            if (number >= 36 && number <=50)
            {
                Console.WriteLine($"{number} is in area [36-50]");
            }
            if (number >= 50 && number <=100)
            {
                Console.WriteLine($"{number} is in area [50-100]");
            }
        }
    }
}
