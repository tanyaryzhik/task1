﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    public class MyCar : Figure
    {
        public MyCar(char symbol, ConsoleColor color)
            : base(symbol, color)
        {
            this.InitializeSate();
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
