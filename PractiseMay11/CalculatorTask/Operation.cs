using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.CalculatorTask
{
    public abstract class Operation
    {
        public virtual string Action { get; }

        public abstract double PerformOperation(double firstNum, double secondNum);

        public override string ToString()
        {
            return $"Calculation is peformed with {this.Action}";
        }
    }
}
