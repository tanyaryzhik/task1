using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class OtherCar : Car
    {
        private int startX;

        public OtherCar(char symbol) : base(symbol)
        {
            this.Initialize();
            this.startX =
        }

        protected override void Initialize()
        {
            this.Nodes = new List<Node> {
                new Node(0,0),
                new Node(2,0),
                new Node(1,1),
                new Node(0,2),
                new Node(1,2),
                new Node(2,2),
                new Node(1,3)
            };
        }

        public void Move()
        {

        }
    }
}
