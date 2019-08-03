using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public abstract class Figure
    {
        protected List<Node> nodes;

        public char symbol;

        public ConsoleColor color;

        //Figure(char symbol, ConsoleColor color);

        public abstract void InitializeSate();

        public abstract void Move(MoveDirection moveDirection, Func<Figure, bool> canMove);
    }
}
