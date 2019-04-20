using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class TaskMethods
    {
        //
        //Calculator
        //
        public static void GetCalculation()
        {
            string[] data = InputData();
            double firstNum = Convert.ToDouble(data[0]);
            double secondNum = Convert.ToDouble(data[1]);
            double result = Calculator(firstNum, secondNum, data[2]);
            WriteResult(firstNum, secondNum, data[2], result);
        }

        private static void WriteResult(double firstNum, double secondNum, string sign, double result)
        {
            if (secondNum == 0 && sign == "/")
                return;
            Console.WriteLine($"{firstNum} {sign} {secondNum} = {result}");
        }

        public static double Calculator(double firstNum, double secondNum, string sign)
        {
            double result = 0.0;
            switch (sign)
            {
                case "+":
                    result = Add(firstNum, secondNum);
                    break;
                case "-":
                    result = Sub(firstNum, secondNum);
                    break;
                case "*":
                    result = Mul(firstNum, secondNum);
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Can't divide by zero");
                        break;
                    }
                    result = Div(firstNum, secondNum);
                    break;
                default:
                    break;
            }
            return result;
        }

        private static double Div(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }

        private static double Mul(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        private static double Sub(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }

        private static double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        private static string[] InputData()
        {
            string[] data = new string[3];
            Console.WriteLine("Input first number");
            data[0] = Console.ReadLine();
            Console.WriteLine("Input second number");
            data[1] = Console.ReadLine();
            Console.WriteLine("Choose action +,-,*,/");
            data[2] = Console.ReadLine();
            return data;
        }

        //
        // Currency converter
        //
        public static void ConvertCurrency()
        {
            decimal amount;
            Console.WriteLine("Input amount of money");
            Decimal.TryParse(Console.ReadLine(), out amount);
            Console.WriteLine("Input currency");
            string currency = Console.ReadLine();
            decimal result = PerformConvertation(amount, currency);
            Report(amount, result,currency);
        }

        private static decimal PerformConvertation(decimal amount, string currency)
        {
            decimal result = 0.00m;
            switch (currency)
            {
                case "dollar":
                    result = Convert.ToDecimal(Convert.ToDouble(amount) * 2.777);
                    break;
                case "euro":
                    result = Convert.ToDecimal(Convert.ToDouble(amount) * 3.125);
                    break;
                case "pound":
                    result = Convert.ToDecimal(Convert.ToDouble(amount) * 5.421);
                    break;
                default:
                    break;
            }
                return result;
            }

            private static void Report(decimal amount, decimal result, string currency)
            {
                Console.WriteLine($"Amount of money {amount} is {result} {currency}");
            }
        }
    }
