﻿using System;
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
            //DeleteDuplicates();
            //GetIndexesOfElementsInRange();
            //GetElementsMoreThanMean();
            //UnpackArray();
            //PerfectNumber();
            int[] array = new int[] {1,2,3,4,5};
            MyReverse(array);
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

        public static void DeleteDuplicates()
        {
            Console.WriteLine("Enter number of elements");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            var random = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(1, 10);
                Console.WriteLine(array[i]);
            }

            int position = 1;
            int[] arrayWithoutDupes = new int[arraySize];
            arrayWithoutDupes[0] = array[0];
            bool isDuplicate = false;
            for (int i = 1; i < arraySize; i++)
            {
                for (int j = 0; j < position + 1; j++)
                {
                    if (array[i] == arrayWithoutDupes[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    arrayWithoutDupes[position] = array[i];
                    position++;
                }
                isDuplicate = false;
            }

            int countZeros = 0;
            foreach (int item in arrayWithoutDupes)
            {
                if (item == 0)
                    countZeros++;
            }

            if (countZeros > 0)
            {
                int arrayClearedSize = arrayWithoutDupes.Length - countZeros;
                int[] arrayCleared = new int[arrayClearedSize];
                Array.Copy(arrayWithoutDupes, arrayCleared, arrayClearedSize);
            }
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

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
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
                if (array[i] > mean)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        public static int[] MyReverse(int[] array)
        {
            int[] revArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                revArray[i] = array[array.Length -1 - i];
            }
            return revArray;
        }

        public static void UnpackArray()
        {
            //
            // User enters array data.
            //
            Console.WriteLine("Enter number of elements");
            int sizeArr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements through space");
            string inputElements = Console.ReadLine();

            //
            // Split string to get elements.
            //
            int[] array = new int[sizeArr];
            string[] splitedArray = inputElements.Split(' ');
            for (int i = 0; i < sizeArr; i++)
            {
                array[i] = Convert.ToInt32(splitedArray[i]);
            }

            //
            // Build unpacked array string.
            //
            StringBuilder resultConstr = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0 && array[i] == 0)
                    continue;
                if (i % 2 != 0)
                    resultConstr.Append(AddElements("1", array[i]));
                if (i % 2 == 0)
                    resultConstr.Append(AddElements("0", array[i]));
            }

            Console.WriteLine(resultConstr.ToString());
        }

        public static string AddElements(string element, int times)
        {
            string result = string.Empty;
            for (int i = 0; i < times; i++)
            {
                result += element;
            }
            return result;
        }

        public static void PerfectNumber()
        {
            for (int k = 2; k <= 1000; k++)
            {
                int sum = 1;
                for (int i = 2; i < k; i++)
                {
                    if (k % i == 0)
                        sum += i;
                }
                if (sum == k)
                    Console.WriteLine($"{k} is perfect");
            }
        }
    }
}
