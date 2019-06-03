using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.Mammals
{
    internal class Arboreal : Mammal
    {
        protected override int WeightIncrease { get => 5; }

        public Arboreal(int age)
            : base(age)
        {
        }

        public override void Move()
        {
            Console.WriteLine("It brachiates");
        }
    }
}
