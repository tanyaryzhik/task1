using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Switcher
{
    public class ElectricalAppliance : ISwitchable
    {
        public string Name { get; }

        public State StateOfElApp { get; set; }

        public ElectricalAppliance(string name)
        {
            this.Name = name;
        }

        public void TurnOn()
        {
            this.StateOfElApp = State.On;
            Console.WriteLine($"Electrical appliance {this.Name} is switched on");
        }

        public void TurnOff()
        {
            this.StateOfElApp = State.Off;
            Console.WriteLine($"Electrical appliance {this.Name} is switched off");
        }
    }
}
