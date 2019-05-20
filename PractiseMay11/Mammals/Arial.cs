using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.Mammals
{
    internal class Aerial: Mammal
    {
        protected override int WeightIncrease { get => 3; }

        public Aerial(int age) : base(age)
        {

        }
        public override void Move()
        {
            Console.WriteLine("It flies");
        }
    }
}
