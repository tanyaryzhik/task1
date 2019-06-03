using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.CalculatorTask
{
    public class Calculator
    {
        private double firstNum;

        private double secondNum;

        public Operation Sum { get; set; }

        public Operation Substract { get; set; }

        public Operation Multiply { get; set; }

        public Operation Divide { get; set; }

        public Calculator(double firstNum, double secondNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
            this.Sum = new SumOperation();
            this.Substract = new SubstractOperation();
            this.Multiply = new MultiplyOperation();
            this.Divide = new DivideOperation();
        }

        private double PerformCalculation(Operation operation, double firstNum, double secondNum)
        {
            if (operation == null)
                throw new ArgumentNullException();
            if (operation == Divide && secondNum == 0.0)
                throw new DivideByZeroException();
            else
                return operation.PerformOperation(firstNum, secondNum);
        }

        public void LaunchCalculation()
        {
            Console.WriteLine(this.Sum.ToString());
            Console.WriteLine(this.PerformCalculation(this.Sum, this.firstNum, this.secondNum));
            Console.WriteLine(this.Substract.ToString());
            Console.WriteLine(this.PerformCalculation(this.Substract, this.firstNum, this.secondNum));
            Console.WriteLine(this.Multiply.ToString());
            Console.WriteLine(this.PerformCalculation(this.Multiply, this.firstNum, this.secondNum));
            Console.WriteLine(this.Divide.ToString());
            Console.WriteLine(this.PerformCalculation(this.Divide, this.firstNum, this.secondNum));
        }
    }
}
