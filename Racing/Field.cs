using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Field
    {
        private int startX;

        private int startY;

        public int Width { get; set; }

        public int Heigth { get; set; }

        private List<Figure> figures;

        public Field()
        {
           this.Initialize();
        }

        private void Initialize()
        {
            this.Width = 10;
            this.Heigth = 20;
            RoadBorder roadBorder = new RoadBorder((char)254, ConsoleColor.DarkBlue);
        }

        private bool IsPositionFree(Figure figure)
        {
            return false;
        }
    }
}
