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
            double[] data = InputAmountAndCourse();
            double result = PerformConvertation(data);
            Report(data, result);
        }

        private static void Report(double[] data, double result)
        {
            Console.WriteLine($"Amount of money {data[0]} is {result} in chosen currency");
        }

        private static double PerformConvertation(double[] data)
        {
            return data[0] * data[1];
        }

        private static double[] InputAmountAndCourse()
        {
            double[] data = new double[2];
            Console.WriteLine("Input amount of money");
            Double.TryParse(Console.ReadLine(), out data[0]);
            Console.WriteLine("Input currency course");
            Double.TryParse(Console.ReadLine(), out data[1]);
            return data;
        }
    }
}
