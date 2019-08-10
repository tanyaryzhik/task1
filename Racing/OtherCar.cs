using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class OtherCar : Figure
    {
        public OtherCar(char symbol, ConsoleColor color)
            : base(symbol, color)
        {
           
        }

        public override void Move(MoveDirection moveDirection, Func<Figure, bool> canMove)
        {
            throw new NotImplementedException();
        }

        protected override void InitializeSate()
        {
            throw new NotImplementedException();
        }
    }
}
