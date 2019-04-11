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
            //GetNumberArea();
            //Translator();
            //BonusCalculation();
            //Factorial();
            //DrawFigures();
            //AnalyzeOfNumber();
            //CalculatorOfPossibleRouts();
            //OperationsWithNumbersBtwAB();
            //HowManyEvenCyfresInNumber();
            //GetArithmeticalMean();
            //Skier();
            //MultiplyTwoNumbers();
            //SquaresBeforeGivenNumber();
            //NumberInvertion();
            //NumberToDegree();
            //DeleteDigitFromNumber();
            //GetMaxDigitInNumber();
            //Syrakusa();
            //SumOfRow();
            GuessNumber();
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
            int operand1 = 0;
            int operand2 = 0;
            string sign = "";
            bool success = false;
            //bool isInputCorrect = false;
            do
            {
                //try
                //{
                //    Console.WriteLine("Input first number");
                //    operand1 = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Input second number");
                //    operand2 = Convert.ToInt32(Console.ReadLine());

                //}
                //catch
                //{
                //    isInputCorrect = true;
                //    continue;
                //}
                //sign = Console.ReadLine();
                //if (sign != "+" && sign != "-" && sign != "*" && sign != "/")
                //{ isInputCorrect = true; }
                //else isInputCorrect = false;

                Console.WriteLine("Input first number");
                success = Int32.TryParse(Console.ReadLine(), out operand1);
                if (success == false)
                    continue;
                Console.WriteLine("Input second number");
                success = Int32.TryParse(Console.ReadLine(), out operand2);
                if (success == false)
                    continue;
                Console.WriteLine("Choose operation +, -, *, /");
                sign = Console.ReadLine();
                if (sign != "+" && sign != "-" && sign != "*" && sign != "/")
                    success = false;



            } while (success == false);

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
                        Console.WriteLine("Can't devide by zero");
                        return;
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
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine($"{number} is in area [0-14]");
            }
            if (number >= 15 && number <= 35)
            {
                Console.WriteLine($"{number} is in area [15-35]");
            }
            if (number >= 36 && number <= 50)
            {
                Console.WriteLine($"{number} is in area [36-50]");
            }
            if (number >= 50 && number <= 100)
            {
                Console.WriteLine($"{number} is in area [50-100]");
            }
        }

        public static void Translator()
        {
            Console.WriteLine("Input russian word");
            string inputString = Console.ReadLine();
            string translation = "";
            switch (inputString)
            {
                case "дождь":
                    translation = "rain";
                    break;
                case "снег":
                    translation = "snow";
                    break;
                case "ясно":
                    translation = "sunny";
                    break;
                case "туман":
                    translation = "mist";
                    break;
                case "ветер":
                    translation = "wind";
                    break;
                case "штиль":
                    translation = "still";
                    break;
                case "шторм":
                    translation = "storm";
                    break;
                case "торнадо":
                    translation = "tornado";
                    break;
                case "ливень":
                    translation = "shower";
                    break;
                case "облака":
                    translation = "cloud";
                    break;
                default:
                    Console.WriteLine("This word has no translation in this app");
                    return;
            }
            Console.WriteLine($"{inputString} in English is {translation}");
        }

        public static void BonusCalculation()
        {
            Console.WriteLine("Input sallary");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input stage");
            int stage = Convert.ToInt32(Console.ReadLine());
            double bonus = 0;

            if (stage < 5)
            {
                bonus = 0.1;
            }
            if (stage >= 5 && stage < 10)
            {
                bonus = 0.15;
            }
            if (stage >= 10 && stage < 15)
            {
                bonus = 0.25;
            }
            if (stage >= 15 && stage < 20)
            {
                bonus = 0.35;
            }
            if (stage >= 20 && stage < 25)
            {
                bonus = 0.45;
            }
            if (stage >= 25)
            {
                bonus = 0.5;
            }
            double result = salary + bonus * salary;
            Console.WriteLine($"Salary {salary} and stage {stage}, bonus is {bonus * salary} and result is {result}");
        }

        public static void Factorial()
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Factorial {number} is {result}");
        }

        public static void DrawFigures()
        {
            Console.WriteLine("Input number of symbols to draw string");
            int numberForString = Convert.ToInt32(Console.ReadLine());
            DrawString(numberForString);
            Console.WriteLine("Input number of symbols to draw rectangle");
            Console.WriteLine("Input height");
            int heightRectangular = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input width");
            int widthRectangular = Convert.ToInt32(Console.ReadLine());
            DrawRectangularFrame(heightRectangular, widthRectangular);
            DrawRectangular(heightRectangular, widthRectangular);
            Console.WriteLine("Input number of symbols to draw triangles");
            int triangleSide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Right triangle");
            DrawRightTriangularFrame(triangleSide);
            DrawRightTriangular(triangleSide);
            Console.WriteLine("Equilateral triangle");
            DrawEquilateralTriangleFrame(triangleSide);



        }

        private static void AnalyzeOfNumber()
        {
            Console.WriteLine("Input number to analyze");
            int testNumber = Convert.ToInt32(Console.ReadLine());
            //
            // string to aggregate report of analyze.
            //
            string report = "";

            //
            // Checking if number is positive or negative.
            //
            if (testNumber > 0)
            {
                report = "Number is positive.\n";
            }
            if (testNumber < 0)
            {
                report = "Number is negative.\nNumber isn't prime.\n";
            }

            //
            // Checking if number is prime.
            //
            int counter = 0;
            for (int i = 2; i <= testNumber; i++)
            {
                if (testNumber % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                report = report + "Number is prime.\n";
            }
            if (counter > 1)
            {
                report = report + "Number isn't prime.\n";
            }

            //
            // Finding number dividers.
            //
            if (testNumber % 2 == 0)
            {
                report = report + "Number is divided by 2.\n";
            }
            if (testNumber % 3 == 0)
            {
                report = report + "Number is divided by 3.\n";
            }
            if (testNumber % 5 == 0)
            {
                report = report + "Number is divided by 5.\n";
            }
            if (testNumber % 6 == 0)
            {
                report = report + "Number is divided by 6.\n";
            }
            if (testNumber % 9 == 0)
            {
                report = report + "Number is divided by 9.\n";
            }

            Console.WriteLine(report);
        }

        private static void DrawEquilateralTriangleFrame(int triangleSide)
        {

            for (int i = 0; i < triangleSide - 1; i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < triangleSide / 2; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
                else if (i == triangleSide - 2)
                    DrawString(triangleSide);
                else
                {
                    for (int k = 0; k < triangleSide / 2 - i - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    for (int k = i - 1; k < triangleSide; k++)
                    {
                        if (k == 0)
                        {
                            Console.WriteLine("*");
                            continue;
                        }
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }

            }
        }

        private static void DrawRightTriangularFrame(int side)
        {
            int hypotenuse;
            for (int i = 0; i < side - 1; i++)
            {
                hypotenuse = i - 1;
                for (int k = 0; k < side - 1; k++)
                {
                    if (k == 0)
                    {
                        Console.Write("*");
                    }
                    if (k == hypotenuse)
                    {
                        Console.Write("*");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            DrawString(side);
        }
        private static void DrawRightTriangular(int side)
        {
            int hypotenuse;
            for (int i = 0; i < side; i++)
            {
                hypotenuse = i - 1;
                for (int k = 0; k < side - 1; k++)
                {
                    if (k == hypotenuse)
                    {
                        Console.Write("*");
                        continue;
                    }
                    else if (k < hypotenuse)
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
            DrawString(side);
        }

        public static void DrawString(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }

        public static void DrawRectangularFrame(int height, int width)
        {
            DrawString(width);
            for (int i = 0; i < height - 2; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    if (k == 0 || k == width - 1)
                    {
                        Console.Write("*");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            DrawString(width);
            Console.Write("\n");
        }

        public static void DrawRectangular(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public static void CalculatorOfPossibleRouts()
        {
            Console.WriteLine("Input number of clients");
            int numberOfClients = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int result = 1;
            do
            {
                result *= i;
                i++;
            } while (i <= numberOfClients);
            Console.WriteLine($"For {numberOfClients} clients it's possible to create {result} ways of delivery route.");
        }

        public static void OperationsWithNumbersBtwAB()
        {
            Console.WriteLine("Input two numbers, first number < second number");
            Console.WriteLine("The first number is");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number is");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            string report = "";
            for (int i = firstNumber + 1; i < secondNumber; i++)
            {
                sum += i;
                if (i % 2 != 0)
                {
                    report += Convert.ToString(i) + ", ";
                }
            }
            Console.WriteLine($"Sum of numbers between {firstNumber} and {secondNumber} is {sum}");
            Console.WriteLine("Odd numbers are " + report);
        }

        public static void HowManyEvenCyfresInNumber()
        {
            Console.WriteLine("Input number");
            string inputNumber = Console.ReadLine();
            int testNumber = Convert.ToInt32(inputNumber);
            int counter = 0;
            int temp = testNumber;
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if ((temp - temp / 10 * 10) % 2 == 0)
                {
                    counter++;
                }
                temp = temp / 10;
            }
            Console.WriteLine($"{counter} even cyfres in {testNumber}");
        }

        public static void GetArithmeticalMean()
        {
            Console.WriteLine("Input lower number");
            int lowerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input higher number");
            int higherNumber = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = lowerNumber; i <= higherNumber; i++)
            {
                sum += i;
                count++;
            }
            double mean = (double
)sum / count;
            Console.WriteLine($"Arithmetical mean of numbers from {lowerNumber} to {higherNumber} is {mean}");
        }

        public static void Skier()
        {
            double way = 10.0;
            int days = 0;
            for (int i = 2; i > 1; i++)
            {
                way = way + way * 1.1;
                if (way >= 100)
                {
                    days = i;
                    break
;
                }
            }
            Console.WriteLine($"Skier will run more than 100 km on the {days} day");
        }

        public static void MultiplyTwoNumbers()
        {
            Console.WriteLine("Input first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int multiplication = 0;
            if ((firstNumber > 0 && secondNumber > 0) || (firstNumber < 0 && secondNumber < 0))
            {
                multiplication = Multiply(Math.Abs(firstNumber), Math.Abs(secondNumber));
            }
            if ((firstNumber > 0 && secondNumber < 0) || (firstNumber < 0 && secondNumber > 0))
            {
                multiplication = -Multiply(Math.Abs(firstNumber), Math.Abs(secondNumber));
            }
            Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplication}");

        }

        private static int Multiply(int firstNumber, int secondNumber)
        {
            int result = 0;
            for (int i = 1; i <= firstNumber; i++)
            {
                result += secondNumber;
            }
            return result;
        }

        public static void SquaresBeforeGivenNumber()
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i >= 1; i++)
            {
                if (i * i <= number)
                {
                    Console.WriteLine($"Square of {i} = {i * i}");
                }
                else
                    break;
            }
        }

        public static void FibonacciLessThanGivenNumber()
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            int fibonacci = 0;
            for (int i = 0; i > 0; i++)
            {
                if (i == 0)
                { fibonacci = 0; }
                if (i == 1 || i == 2)
                { fibonacci = 1; }
                else
                { }
                Console.WriteLine($"F{i} = {fibonacci}");
            }
        }

        public static void NumberInvertion()
        {
            Console.WriteLine("Input number");
            string inputNumber = Console.ReadLine();
            int number = Convert.ToInt32(inputNumber);
            int temp = number;
            int digit = 0;
            int invertedNumber = 0;
            string invertedNumStr = "";
            for (int i = 0; i < inputNumber.Length; i++)
            {
                digit = temp - temp / 10 * 10;
                invertedNumStr += digit;
                temp = temp / 10;
            }
            invertedNumber = Convert.ToInt32(invertedNumStr);
            temp = invertedNumber;
            Console.WriteLine($"Number {number} consists of");
            for (int i = 0; i < inputNumber.Length; i++)
            {
                digit = temp - temp / 10 * 10;
                Console.WriteLine(digit);
                temp = temp / 10;
            }
            Console.WriteLine($"{number} inverts to {invertedNumber}");
        }

        public static void NumberToDegree()
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input degree");
            int degree = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i <= Math.Abs(degree); i++)
            {
                if (i == 0)
                { result = 1; }
                else
                {
                    result *= number;
                }
            }
            if (degree < 0)
            {
                Console.WriteLine($"Number {number} to {degree} degree is 1/{result}");
            }
            else
                Console.WriteLine($"Number {number} to {degree} degree is {result}");
        }

        public static void DeleteDigitFromNumber()
        {
            Console.WriteLine("Input number");
            string originNumStr = Console.ReadLine();
            int originNum = Convert.ToInt32(originNumStr);
            Console.WriteLine("Input digit to delete");
            string digitStr = Console.ReadLine();
            int digitNum = Convert.ToInt32(digitStr);
            int temp = originNum;
            int unit = 0;
            string tempNumberStr = "";
            string resultNumberStr = "";
            for (int i = 0; i < originNumStr.Length; i++)
            {
                unit = temp - temp / 10 * 10;
                if (unit != digitNum)
                {
                    tempNumberStr += unit;
                }
                temp = temp / 10;
            }
            temp = Convert.ToInt32(tempNumberStr);
            for (int i = 0; i < tempNumberStr.Length; i++)
            {
                unit = temp - temp / 10 * 10;
                resultNumberStr += unit;
                temp = temp / 10;
            }
            Console.WriteLine(resultNumberStr);
        }

        public static void GetMaxDigitInNumber()
        {
            Console.WriteLine("Input number");
            string numStr = Console.ReadLine();
            int number = Convert.ToInt32(numStr);
            int unit = 0;
            int temp = number;
            int max = 0;
            for (int i = 0; i < numStr.Length; i++)
            {
                unit = temp - temp / 10 * 10;
                if (max < unit)
                { max = unit; }
                temp = temp / 10;
            }
            Console.WriteLine($"Max number is {max}");
        }

        public static void Syrakusa()
        {
            Console.WriteLine("Input number");
            string numStr = Console.ReadLine();
            int number = Convert.ToInt32(numStr);
            int temp = number;
            do
            {
                if (temp % 2 == 0)
                {
                    temp = temp / 2;
                }
                else
                {
                    temp = (temp * 3 + 1) / 2;
                }
            } while (temp > 1);
            Console.WriteLine($"Result number is {temp}");
        }

        public static void SumOfRow()
        {
            Console.WriteLine("Input number of addends of row");
            string numStr = Console.ReadLine();
            int number = Convert.ToInt32(numStr);
            double sum = 0.0;
            int twoPowered = 1;
            for (int i = 1; i <= number; i++)
            {
                twoPowered = twoPowered * 2;
                if (i % 2 == 0)
                {
                    sum = sum - (double)i/twoPowered;
                }
                if (i % 2 != 0)
                {
                    sum = sum + (double)i/twoPowered;
                }
            }
            Console.WriteLine(sum);
        }

        public static void GuessNumber()
        {
            Console.WriteLine("Try to guess number chosen by computer from 0 to 100");
            int random = new Random().Next(100);
            int userNumber = 0;
            do
            {
                userNumber = 0;
                Console.WriteLine("Input number");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber > random)
                    Console.WriteLine($"{userNumber} > computre's number");
                else if (userNumber < random)
                    Console.WriteLine($"{userNumber} < computre's number");
                else if (userNumber == random)
                {
                    Console.WriteLine($"Yes, it's {random}. Congratulations!!!");
                    break;
                }
            } while (userNumber!=random);
        }
    }

}

