using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.FigureTask
{
    class Square : Figure
    {
        public double Side { get; set; }

        public Square(double x, double y, double side)
            : base(x, y)
        {
            this.Side = side;
        }

        public void Draw()
        {
            Console.WriteLine($"The square with side {this.Side} is drawn. Center of square is on x: {this.coordX}, y: {this.coordY}");
        }
    }
}
