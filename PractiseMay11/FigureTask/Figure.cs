using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.FigureTask
{
    internal class Figure
    {
        public double coordX { get; set; }

        public double coordY { get; set; }

        public Figure(double x, double y)
        {
            this.coordX = x;
            this.coordY = y;
        }
    }
}
