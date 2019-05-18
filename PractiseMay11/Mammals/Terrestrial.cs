using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.Mammals
{
    internal class Terrestrial : Mammal
    {
        protected override int WeightIncrease { get => 1; }
        public Terrestrial(int age) : base(age)
        {

        }
    }
}
