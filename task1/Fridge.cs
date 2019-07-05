using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Fridge : Device, Interfaces.ITemperature
    {
        public int Temperature
        {
            get => this.Temperature;

            private set
            {
                this.Temperature = value;
            }
        }

        public void TemperatureDown()
        {
            this.Temperature--;
        }

        public void TemperatureUp()
        {
            this.Temperature++;
        }
    }
}
