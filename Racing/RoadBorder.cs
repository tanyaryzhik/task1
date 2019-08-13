using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void DrawBorder()
        {
            for (int i = 0; i < this.nodes.Count; i++)
            {
                Console.SetCursorPosition(this.nodes[i].coordX, this.nodes[i].coordY);
                if (i != 3)
                Console.Write('N');
            }
        }

        //public void
    }
}
