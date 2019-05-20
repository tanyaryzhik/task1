using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FurAnimals
{
    public class Dog : Animal
    {
        public override void Bite()
        {
            Console.WriteLine($"Dog {this.Name} bites");
        }
    }
}
