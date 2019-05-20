using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FurAnimals
{
    public class Cat : Animal, IPurr
    {
        public override void Bite()
        {
            Console.WriteLine($"Cat {this.Name} bites");
        }

        public void Purr()
        {
            Console.WriteLine($"Cat {this.Name} purrs");
        }
    }
}
