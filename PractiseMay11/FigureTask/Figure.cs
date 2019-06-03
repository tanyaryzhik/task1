using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FigureTask
{
    public class Figure
    {
        public double CoordX { get; set; }

        public double CoordY { get; set; }

        public Figure(double x, double y)
        {
            this.CoordX = x;
            this.CoordY = y;
        }

        public virtual void Draw()
        {
            
        }
    }
}
