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
            //DeleteDuplicates();
            //GetIndexesOfElementsInRange();
            //GetElementsMoreThanMean();
            //UnpackArray();
            //PerfectNumber();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] arrayDuo = { { 1, 2, 3, 1, 5 }, { 4, 3, 1, 2, 1 } };
            //MyReverse(array);
            //SubArray(array, 3, 10);
            //AddElementToArray(array);
            //AddValueToBeginningOfArray(array, 9);
            //HowManyValues(arrayDuo, 1);
            //ChangeStringsOfMatrix();
            //GetSumOfPurchase();
            Encrypt();
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
                revArray[i] = array[array.Length - 1 - i];
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

        public static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];
            int tempIndex = index;
            for (int i = 0; i < count; i++)
            {
                if (tempIndex < array.Length)
                    subArray[i] = array[tempIndex];
                else
                    subArray[i] = 1;

                tempIndex++;
            }
            return subArray;
        }

        public static int[] AddElementToArray(int[] array)
        {
            int[] addedArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                addedArray[i] = array[i];
            }
            return addedArray;
        }

        public static int[] AddValueToBeginningOfArray(int[] array, int value)
        {
            int[] addedArray = new int[array.Length + 1];
            addedArray[0] = value;
            for (int i = 0; i < array.Length; i++)
            {
                addedArray[i + 1] = array[i];
            }
            return addedArray;
        }

        public static int HowManyValues(int[,] array, int value)
        {
            int count = 0;
            foreach (int item in array)
            {
                if (item == value)
                    count++;
            }
            return count;
        }

        public static void ChangeStringsOfMatrix()
        {
            Console.WriteLine("This is given matrix of numbers");
            int[,] array = new int[5, 7];
            var random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    array[i, j] = random.Next(100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter number of strings you want to replace");
            Console.WriteLine("String number:");
            int strNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Replace with string number:");
            int strNum2 = Convert.ToInt32(Console.ReadLine());

            int temp = 0;

        }

        public static void GetSumOfPurchase()
        {
            string[] items = new string[10] { "pear", "apple", "cucumber", "tomato", "dill", "parsley", "chicken", "cheese", "butter", "milk" };
            double[] price = new double[10] { 40.50, 31.20, 21.80, 35.00, 150.00, 145.00, 200.00, 400.00, 81.40, 53.35 };
            Console.WriteLine("Enter items and quantity to purchase.");
            bool isListFull = false;
            double[] quantity = new double[10];
            string item = string.Empty;
            double itemQuantity = 0.0;
            string answer = string.Empty;
            double sum = 0.0;
            do
            {
                Console.WriteLine("Item");
                item = Console.ReadLine();
                Console.WriteLine("Quantity");
                itemQuantity = Convert.ToDouble(Console.ReadLine());
                FillQuantityArray(item, itemQuantity, items,ref quantity);
                Console.WriteLine("Continue? Y/N");
                answer = Console.ReadLine();
                if (answer == "n")
                    isListFull = true;
                else
                    isListFull = false;

            } while (isListFull == false);

            for (int i = 0; i < quantity.Length; i++)
            {
                if (quantity[i] !=0)
                {
                    sum += (double)quantity[i] * price[i];
                }

            }
            Console.WriteLine($"Sum of purchase is {sum}");
        }

        private static void FillQuantityArray(string item, double itemQuantity, string[] items,ref double[]quantity)
        {
            for (int i = 0; i < items.Length;i++)
            {
                if (items[i] == item)
                {
                    quantity[i] = itemQuantity;
                    break;
                }

            }
        }

        public static void Encrypt()
        {
            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };
            Console.WriteLine("Enter the message");
            string inputMessage = Console.ReadLine();
            char[] encryptedMessage = new char[inputMessage.Length];
            for (int i = 0; i < inputMessage.Length; i++)
            {
                for (int j = 0; j < encryptChars.Length; j++)
                {
                    if (inputMessage[i] == encryptChars[j])
                        encryptedMessage[i] = cipher[j];
                }
                if (encryptedMessage[i] == '\x0000')
                    encryptedMessage[i] = cipher[10];
            }

            foreach (char symbol in encryptedMessage)
            {
                Console.Write(symbol);
            }

        }
    }
}
