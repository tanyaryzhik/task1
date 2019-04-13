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
            //arrayAnalyze();
            //DeleteDublicates();
            //GetIndexesOfElementsInRange();
            GetElementsMoreThanMean();
            Console.ReadLine();
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }

        public static void arrayAnalyze()
        {
            Console.WriteLine("Enter number of elements");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(100);
                Console.WriteLine(array[i]);
            }

            int min = 100;
            int max = 0;
            int sum = 0;
            double mean = 0.0;
            string oddNumbers = "";
            for (int i = 0; i < array.Length; i++)
            {
                // Max & min
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k] && array[i] > max)
                    {
                        max = array[i];
                    }

                    if (array[i] < array[k] && array[i] < min)
                    {
                        min = array[i];
                    }
                }

                // Sum
                sum += array[i];

                // Odd
                if (array[i] % 2 != 0)
                {
                    oddNumbers = oddNumbers + array[i] + " ";
                }
            }
            mean = (double)sum / array.Length;
            Console.WriteLine($"Max element {max}\nMin element {min}\nOdd numbers {oddNumbers}\nSum {sum}\nArithmetical mean {mean}");
        }

        public static void DeleteDublicates()
        {
            Console.WriteLine("Enter number of elements");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(10);
                Console.WriteLine(array[i]);
            }

            int counterDublicates = 0;
            int[] indexDublicates = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)

                {
                    if (array[i] == array[k])
                    {
                        indexDublicates[i] = i;
                        counterDublicates++;
                    }
                }
            }
            int arrSizeCleared = array.Length - counterDublicates;
            int[] arrayCleared = new int[arrSizeCleared];

        }

        public static void GetIndexesOfElementsInRange()
        {
            Console.WriteLine("Enter number of elements");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max value less than 100");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter min value more than 0");
            int min = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(100);
                Console.WriteLine(array[i]);
            }

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]>=min && array[i]<=max)
                {
                    Console.WriteLine($"Element {array[i]} with index {i}");
                }
            }
        }

        public static void GetElementsMoreThanMean()
        {
            var random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
                Console.WriteLine(array[i]);
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double mean = (double)sum / array.Length;
            Console.WriteLine($"Mean {mean}");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]> mean)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
