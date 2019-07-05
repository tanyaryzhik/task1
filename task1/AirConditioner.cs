using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class AirConditioner : Device, Interfaces.ITemperature, Interfaces.IBlow
    {
        public int Temperature
        {
            get => this.Temperature;
            private set
            {
                this.Temperature = value;
            }
        }

        public void Blow()
        {
            Console.WriteLine("Blow");
        }

        public void StopBlow()
        {
            Console.WriteLine("Stop blow");
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
