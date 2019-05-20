using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.Humans
{
    public abstract class Human
    {
        public string Name { get; set; }

        public abstract void SayHello();
    }
}
