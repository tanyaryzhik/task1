using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FigureTask
{
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double x, double y, double radius)
            : base(x, y)
        {
            this.Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"The circle with a radius {this.Radius} is drawn. Center of circle is on x: {this.coordX}, y: {this.coordY}");
        }
    }
}
