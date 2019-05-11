using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.FigureTask
{
    internal class Diamond : Figure
    {
        public double Side { get; set; }

        public Diamond(double x, double y, double side)
            : base(x, y)
        {
            this.Side = side;
        }
    }
}
