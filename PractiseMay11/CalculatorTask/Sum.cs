using PractiseMay18.CalculatorTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.CalculatorTask
{
    public class SumOperation : Operation
    {
        public override string Action { get => "Sum operation"; }

        public override double PerformOperation(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
