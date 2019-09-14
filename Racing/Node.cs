using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Node
    {
        public int coordX { get; set; }

        public int coordY { get; set; }

        public Node(int x, int y)
        {
            this.coordX = x;
            this.coordY = y;
        }

        public void Up()
        {
            this.coordY--;
        }

        public void Down()
        {
            this.coordY++;
        }

        public void Left()
        {
            this.coordX--;
        }

        public void Right()
        {
            this.coordX++;
        }
    }
}
