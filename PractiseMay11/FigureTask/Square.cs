using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FigureTask
{
    public class Square : Figure
    {
        public double Side { get; }

        public Square(double x, double y, double side)
            : base(x, y)
        {
            this.Side = side;
        }

        public override void Draw()
        {
            Console.WriteLine($"The square with side {this.Side} is drawn. Center of square is on x: {this.CoordX}, y: {this.CoordY}");
        }
    }
}
