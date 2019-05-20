using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.FurAnimals
{
    public class Lynx : Animal, IPurr
    {
        public override void Bite()
        {
            Console.WriteLine($"Lynx {this.Name} bites");
        }

        public void Purr()
        {
            Console.WriteLine($"Lynx {this.Name} purrs");
        }
    }
}
