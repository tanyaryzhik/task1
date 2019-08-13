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

        public Car(char symbol)
        {
            this.symbol = symbol;
            Initialize();
        }

        protected virtual void Initialize()
        {
            this.Nodes = new List<Node> {
                new Node(1,0),
                new Node(0,1),
                new Node(1,1),
                new Node(2,1),
                new Node(1,2),
                new Node(0,3),
                new Node(2,3)
            };
            
        }

        protected void Move(MoveDirection direction)
        {
            foreach (Node node in this.Nodes)
            {
                switch (direction)
                {
                    case MoveDirection.Down:
                        {
                            node.Down();
                            break;
                        }
                    case MoveDirection.Up:
                        {
                            node.Up();
                            break;
                        }
                    case MoveDirection.Right:
                        {
                            node.Right();
                            break;
                        }
                    case MoveDirection.Left:
                        {
                            node.Left();
                            break;
                        }
                }
            }
        }
    }
}
