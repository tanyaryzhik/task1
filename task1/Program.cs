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
            //Hometask1_1();
            //Hometask1_2();
            //Hometask1_3();
            //Hometask1_4();
            Hometask1_5();
            Console.ReadLine();
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }

        public static void Hometask1_1()
        {
            int x1 = -6598269;
            Console.WriteLine(x1);
        }

        public static void Hometask1_2()
        {
            string str1;
            Console.WriteLine("Ваше имя?");
            str1 = Console.ReadLine();
            string str2 = "Привет, " + str1;
            Console.WriteLine(str2);
        }

        public static void Hometask1_3()
        {
            var v1 = 'v';
            v1 = 't';
            Console.WriteLine(v1);
        }

        public static void Hometask1_4()
        {
            Console.WriteLine("Input side of square");
            string str = Console.ReadLine();
            int side = Convert.ToInt32(str);
            Console.WriteLine($"Perimeter is {4 * side}");
        }

        public static void Hometask1_5()
        {
            Console.WriteLine("Input R1");
            int rad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input R2");
            int rad2 = Convert.ToInt32(Console.ReadLine());
            double square1 = 3.14 * rad1 * rad1;
            double square2 = 3.14 * rad2 * rad2;
            double square3 = square1 - square2;
            Console.WriteLine($"Square 1 is {square1} \nSquare 2 is {square2}");
            Console.WriteLine($"Square of ring is {square3}");
        }
    }
}
