using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing
{
    public class RoadBorder
    {
        private List<Node> nodes;

        public RoadBorder()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            this.nodes = new List<Node>();
            for (int i = 0; i < 20; i++)
            {
                this.nodes.Add(new Node(0, i));
                this.nodes.Add(new Node(9, i));
            }
        }

        public void Draw()
        {
            for (int i = 0; i < this.nodes.Count; i++)
            {
                Console.SetCursorPosition(this.nodes[i].coordX, this.nodes[i].coordY);
                if (i == 6 || i == 7 || i == 14 || i == 15 || i == 22 || i == 23 || i == 30 || i == 31 || i == 38 || i == 39)
                    Console.Write(' ');
                else
                    Console.Write('N');

            }
        }

        public void MoveBorder()
        {
            while (true)
            {
                for (int i = 0; i < this.nodes.Count; i++)
                {
                    if (this.nodes[i].coordY == 20)
                        this.nodes[i].coordY = 0;

                    this.nodes[i].Down();
                }
                Draw();
                Thread.Sleep(500);
            }
        }
    }
}
