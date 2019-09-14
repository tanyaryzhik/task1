using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Racing
{
    public class OtherCar : Car
    {
        public OtherCar(char symbol)
           : base(symbol)
        {
            this.Initialize();
        }

        protected override void Initialize()
        {
            this.rightPosition = new List<Node>
            {
                new Node(5,0),
                new Node(7,0),
                new Node(6,1),
                new Node(7,2),
                new Node(6,2),
                new Node(5,2),
                new Node(6,3)
            };

            this.leftPosition = new List<Node>
            {
                new Node(2,0),
                new Node(4,0),
                new Node(3,1),
                new Node(4,2),
                new Node(3,2),
                new Node(2,2),
                new Node(3,3)
            };

            this.Nodes = this.leftPosition;
        }

        public void Move()
        {
            char temp = ' ';
            
            do
            {
                this.Draw();
                temp = this.symbol;
                this.symbol = ' ';
                this.Draw();
                this.symbol = temp;
                
                this.Down();
                
                    foreach (var item in this.Nodes)
                    {
                        if (item.coordY == 19)
                            item.coordY = 0;
                    }
               
               
                Thread.Sleep(1000);
            } while (true);
        }

        private void Down()
        {
            foreach (var item in this.Nodes)
            {
                item.Down();
            }
        }
    }
}
