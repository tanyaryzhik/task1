using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Switcher
{
    public class Lamp : ISwitchable
    {
        public string Name { get; set; }

        public State StateOfLamp { get; set; }

        public Lamp(string name)
        {
            this.Name = name;
        }

        public void TurnOn()
        {
            this.StateOfLamp = State.On;
            Console.WriteLine($"Lamp {this.Name} is switched on");
        }

        public void TurnOff()
        {
            this.StateOfLamp = State.Off;
            Console.WriteLine($"Lamp {this.Name} is switched off");
        }
    }
}
