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
            double firstNum = GetNumber();
            double secondNum = GetNumber();
            string sign = GetSign();
            double result = Calculator(firstNum, secondNum, sign);
            WriteResult(firstNum, secondNum, sign, result);
        }

        private static string GetSign()
        {
            Console.WriteLine("Input sign of action +, -, *, /");
            string sign = Console.ReadLine();
            if (sign != "+" && sign != "-" && sign != "*" && sign != "/")
            {
                Console.WriteLine("Input data is not valid");
                throw new ArgumentException(String.Format($"{sign} is not +, -, *, /"));
            }
            else
                return sign;
        }

        private static double GetNumber()
        {
            Console.WriteLine("Input number");
            bool success = Double.TryParse(Console.ReadLine(), out double number);
            if (success == false)
            {
                Console.WriteLine("Input data is not valid");
                throw new ArgumentException(String.Format($"{number} is not a number"));
            }
            else
                return number;
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
            Report(amount, result, currency);
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

        //
        // Credit.
        //
        public static void GetCreditCondition()
        {
            decimal credit = 700;
            Console.WriteLine("Input amount of payment");
            Decimal.TryParse(Console.ReadLine(), out decimal amount);
            if (amount < 100)
            {
                Console.WriteLine("Payment must be 100 minimum");
                return;
            }
            decimal rest = CreditCalculation(credit, amount);
            AnalyzeOfRest(rest, credit);
        }

        private static void AnalyzeOfRest(decimal rest, decimal credit)
        {
            if (rest > 0)
                Console.WriteLine($"You have to pay {rest}");
            if (rest < 0)
                Console.WriteLine($"Overpayment is {Math.Abs(rest)}");
            if (rest == 0)
                Console.WriteLine("Credit is paid");

        }

        private static decimal CreditCalculation(decimal credit, decimal amount)
        {
            return credit - amount;
        }

        //
        // ATM Pin validation.
        //
        //public static bool Validation()
        //{
        //    Console.WriteLine("Input PIN");
        //    string inputStr = Console.ReadLine();
        //    return ValidatePin(inputStr);
        //}

        //private static bool ValidatePin(string inputStr)
        //{
        //    if (isAllNumbers(inputStr) && isNumOfElementsValid(inputStr))
        //        return true;
        //}

        private static bool isNumOfElementsValid(string inputStr)
        {
            return true;
        }

        private static bool isAllNumbers(string inputStr)
        {
            return Int32.TryParse(inputStr, out int result);
        }
    }
}
