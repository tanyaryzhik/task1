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
            : base(symbol, color)
        {

        }

        protected override void InitializeSate()
        {
            this.Nodes = new List<Node>();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    this.Nodes[i] = new Node(j, i);
                    this.Nodes[i + 20] = new Node(j, 9);
                }
            }
        }

        public void Move()
        {
            for (int i = 0; i < this.Nodes.Count; i++)
            {
                this.Nodes[i].Down();
            }

        }
    }
}
