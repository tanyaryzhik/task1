using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class MyCar : Car
    {


        public MyCar(char symbol) : base(symbol)
        {
            this.rightPosition = new List<Node>
            {
                new Node(6,15),
                new Node(5,16),
                new Node(6,16),
                new Node(7,16),
                new Node(6,17),
                new Node(5,18),
                new Node(7,18)
            };

            this.leftPosition = new List<Node>
            {
                new Node(3,15),
                new Node(2,16),
                new Node(3,16),
                new Node(4,16),
                new Node(3,17),
                new Node(2,18),
                new Node(4,18)
            };

            this.Nodes = this.leftPosition;
        }

       

        public void Move(ConsoleKeyInfo key)
        {
            char temp = ' ';

            if (key.Key == ConsoleKey.LeftArrow)
            {
                temp = this.symbol;
                this.symbol = ' ';
                this.Draw();
                this.symbol = temp;
                this.LeftPosition();
                this.Draw();
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                temp = this.symbol;
                this.symbol = ' ';
                this.Draw();
                this.symbol = temp;
                this.RightPosition();
                this.Draw();
            }
        }
    }
}
