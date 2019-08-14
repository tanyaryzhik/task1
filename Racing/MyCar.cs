using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class MyCar : Car
    {
        public MyCar(char symbol) : base(symbol)
        {
        }

        public override void Move(MoveDirection direction)
        {

            base.Move(direction);
        }
    }
}
