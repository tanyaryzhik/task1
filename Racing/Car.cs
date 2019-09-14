using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class Car
    {
        protected char symbol;

        public List<Node> Nodes { get; set; }

        protected List<Node> rightPosition;

        protected List<Node> leftPosition;

        public Car(char symbol)
        {
            this.symbol = symbol;
            Initialize();
        }

        protected virtual void Initialize()
        {
            this.Nodes = new List<Node>
            {
                new Node(1,0),
                new Node(0,1),
                new Node(1,1),
                new Node(2,1),
                new Node(1,2),
                new Node(0,3),
                new Node(2,3),
            };
        }

        public virtual void Draw()
        {
            lock (Program.locker)
            {
                foreach (Node node in this.Nodes)
                {
                    Console.SetCursorPosition(node.coordX, node.coordY);
                    Console.WriteLine(this.symbol);
                }
            }
        }

        protected virtual void LeftPosition()
        {
            this.Nodes = this.leftPosition;
        }

        protected virtual void RightPosition()
        {
            this.Nodes = this.rightPosition;
        }
    }
}
