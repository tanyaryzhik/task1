using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FigureTask
{
    internal class Triangle : Figure
    {
        public double BaseSide { get; set; }

        public double Height { get; set; }

        public Triangle(double x, double y, double baseSide, double height)
            : base(x, y)
        {
            this.BaseSide = baseSide;
            this.Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"The triangle with base {this.BaseSide} and height {this.Height} is drawn. Center of triangle is on x: {this.coordX}, y: {this.coordY}");
        }
    }
}
