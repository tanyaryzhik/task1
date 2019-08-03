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

        public int Width { get; }

        public int Heigth { get; }

        private List<Figure> figures;

        public Field()
        {
            this.Width = this.startX + 10;
            this.Heigth = this.startY + 20;
        }

        private void Initialize()
        {
            this.startX = 10;
            this.startY = 10;
            //initialize figure list
  
        }

        private bool IsPositionFree(Figure figure)
        {
            return false;
        }
    }
}
