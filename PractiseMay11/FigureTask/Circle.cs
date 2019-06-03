using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FigureTask
{
    public class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double x, double y, double radius)
            : base(x, y)
        {
            this.Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"The circle with a radius {this.Radius} is drawn. Center of circle is on x: {this.CoordX}, y: {this.CoordY}");
        }
    }
}
