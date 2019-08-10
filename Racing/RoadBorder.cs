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
               
                
            }
        }

        public override void Move(MoveDirection moveDirection, Func<Figure, bool> canMove)
        {
            throw new NotImplementedException();
        }
    }
}
