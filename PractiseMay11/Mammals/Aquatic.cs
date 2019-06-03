using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.Mammals
{
    public class Aquatic : Mammal
    {
        protected override int WeightIncrease { get => 4; }

        public Aquatic(int age)
                      : base(age)
        {
        }

        public override void Move()
        {
            Console.WriteLine("It swims");
        }
    }
}
