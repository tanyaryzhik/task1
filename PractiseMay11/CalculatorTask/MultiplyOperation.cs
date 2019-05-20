﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.CalculatorTask
{
    public class MultiplyOperation : Operation
    {
        public override string Action { get => "Multiply operation"; }

        public override double PerformOperation(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
    }
}
