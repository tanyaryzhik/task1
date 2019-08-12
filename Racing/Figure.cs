using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public abstract class Figure
    {
        protected List<Node> Nodes { get; set; }

        public char Symbol { get; set; }

        public ConsoleColor Color { get; set; }

        public Figure(char symbol, ConsoleColor color)
        {
            this.Symbol = symbol;
            this.Color = color;
            this.InitializeSate();
        }

        protected abstract void InitializeSate();
              
        //public abstract void Move(MoveDirection moveDirection, Func<Figure, bool> canMove);
    }
}
