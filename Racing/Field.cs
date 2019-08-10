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
           this.Initialize();
        }

        private void Initialize()
        {
           
            //initialize figure list
  
        }

        private bool IsPositionFree(Figure figure)
        {
            return false;
        }
    }
}
