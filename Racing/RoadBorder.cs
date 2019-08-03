using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class RoadBorder : Figure
    {
        public RoadBorder(char symbol, ConsoleColor color)
        {
            this.symbol = symbol;
            this.color = color;


        }

        public override void InitializeSate()
        {
            this.nodes = new List<Node>
            {
                new Node(0, 0),
                new Node(10, 0)
            };
            for (int i = 0; i < 20; i++)
            {
                foreach (var item in nodes)
                {
                    Console.WriteLine(item.);
                }
            }
        }

        public override void Move(MoveDirection moveDirection, Func<Figure, bool> canMove)
        {
            throw new NotImplementedException();
        }
    }
}
