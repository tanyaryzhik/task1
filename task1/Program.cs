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
            //HowManySymbolInText();
            //InsertString();
            //DeleteSpaces();
            //DeleteExcessSpaces();
            //FirstSymbolOfWordByNumber();
            //TransformToUpperCase();
            //ErrorPrint();
            //GetNumberOfVowels();
            ReplaceWords();
            Console.ReadLine();
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }

        public static void HowManySymbolInText()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine("What symbol do you want to count?");
            char symbol = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                    count++;
            }
            Console.WriteLine($"Symbol {symbol} is met {count} times");
        }

        public static void InsertString()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter inserted text");
            string insertedText = Console.ReadLine();
            Console.WriteLine("In what position should text be inserted?");
            int position = Convert.ToInt32(Console.ReadLine());
            string result = text.Insert(position, insertedText);
            Console.WriteLine(result);
        }

        public static void DeleteSpaces()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            //string result = string.Empty;

            int index1 = text.IndexOf('?', 0);
            int index2 = text.IndexOf('?', index1 + 1);
            char[] result = new char[text.Length];
            StringBuilder str = new StringBuilder();
            str = str.Append(text);
            str.Replace(" ", null, index1, index2 - index1);
            Console.WriteLine(str);

        }

        public static void DeleteExcessSpaces()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            string[] array = text.Split(' ');
            foreach (string item in array)
            {
                item.Trim();
            }
            foreach (string item in array)
            {
                if (item == string.Empty)
                    continue;
                else
                    Console.Write(item + " ");
            }
        }

        public static void FirstSymbolOfWordByNumber()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            string[] array = text.Split(' ');
            Console.WriteLine("Input number of word");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(array[position - 1][0]);

        }

        public static void TransformToUpperCase()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            string[] array = text.Split(' ');
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i][0].ToString().ToUpper() + array[i].Substring(1);
            }
            Console.WriteLine(string.Join(" ", array));
        }

        public static void ErrorPrint()
        {
            Console.WriteLine("Input printer string");
            string text = Console.ReadLine();
            int count = 0;
            int countError = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'b' || text[i] == 'c' || text[i] == 'd' || text[i] == 'e' || text[i] == 'f' || text[i] == 'g' || text[i] == 'h' ||
                    text[i] == 'i' || text[i] == 'j' || text[i] == 'k' || text[i] == 'l' || text[i] == 'm')
                    count++;
                if (text[i] == 'n' || text[i] == 'o' || text[i] == 'p' || text[i] == 'q' || text[i] == 'r' || text[i] == 's' || text[i] == 't' || text[i] == 'u'
                    || text[i] == 'v' || text[i] == 'w' || text[i] == 'x' || text[i] == 'y' || text[i] == 'z')
                    countError++;
            }
            Console.WriteLine($"The result is {countError}/{count}");
        }

        public static int GetNumberOfVowels()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'o' || text[i] == 'u' || text[i] == 'e' || text[i] == 'i')
                    count++;
            }
            Console.WriteLine(count);
            return count;
        }

        public static void ReplaceWords()
        {
            Console.WriteLine("Input text");
            string text = Console.ReadLine();
            string[] array = text.Split(' ');
            string result = string.Empty;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result += array[i] + " ";
            }
            Console.WriteLine(result);
        }
    }
}
