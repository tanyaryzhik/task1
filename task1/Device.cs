using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public enum State
    {
        TurnOff = 0,
        TurnOn = 1
    }

    public class Device : Interfaces.ISwitchable
    {
        public string Name { get; set; }

        public State DeviceState { get; set; }

        public void TurnOff()
        {
            this.DeviceState = State.TurnOff;
        }

        public void TurnOn()
        {
            this.DeviceState = State.TurnOn;
        }
    }
}
