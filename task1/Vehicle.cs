using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Vehicle
    {
        public ConsoleColor Color { get; set; }
        public int PassengerCount { get; set; }
        private int wheelCount = 1;
        public int WheelCount
        {
            get
            {
                return wheelCount;
            }
            set
            {
                if (value > 0)
                {
                    wheelCount = value;
                }
            }
        }
        private int maxSpeed = 1;
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0)
                {
                    maxSpeed = value;
                }
            }
        }
        public StringBuilder header { get; set; }
        public StringBuilder vehicleData { get; set; }


        public Vehicle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
        {
            WheelCount = wheelCount;
            Color = color;
            MaxSpeed = maxSpeed;
            PassengerCount = passengerCount;
            header = new StringBuilder(String.Format("{0,20} {1,20} {2,20} {3,20}", "WheelCount", "MaxSpeed", "PassengerCount", "Color"));
            vehicleData = new StringBuilder(String.Format("{0,20} {1,20} {2,20} {3,20}", WheelCount, MaxSpeed, PassengerCount, Color));
        }

        public void Move(int meters)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"{GetType().Name} has moved {meters} metres");
        }

        public void DisplayInfo()
        {
            Console.BufferWidth = 800;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(header);
            Console.WriteLine(vehicleData);
        }
    }
}
