using PractiseMay11.Humans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.Humans
{
    public class Ukrainian : Human
    {
        public Ukrainian(string name)
        {
            this.Name = name;
        }
        public override void SayHello()
        {
            Console.WriteLine("Привіт");
        }
    }
}
