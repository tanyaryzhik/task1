using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.Mammals
{
    internal class Arial: Mammal
    {
        protected override int WeightIncrease { get => 3; }
        public Arial(int age) : base(age)
        {

        }
    }
}
