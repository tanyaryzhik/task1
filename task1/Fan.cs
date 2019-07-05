using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public enum Speed
    {
        Low = 0,
        Medium = 1,
        High = 2
    }
    public class Fan : Interfaces.IBlow
    {
        public Speed Speed { get; set; }

        public bool IsSwing { get; set; }

        public void Blow()
        {
            Console.WriteLine("Blow");
        }

        public void StopBlow()
        {
            Console.WriteLine("Stop blow");
        }

        public void SwitchSpeed()
        {
            this.Speed++;
        }

        public void SwitchSwing()
        {
            this.IsSwing = !this.IsSwing;
        }
    }
}
