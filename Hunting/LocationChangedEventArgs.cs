using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunting
{
    public class LocationChangedEventArgs : EventArgs
    {
        public double coordX;

        public double coordY;

        public LocationChangedEventArgs(double x, double y)
        {
            this.coordX = x;
            this.coordY = y;
        }
    }
}
