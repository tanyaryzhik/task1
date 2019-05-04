using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public EngineType Engine { get; set; }
        public GearBoxType GearBox { get; set; }

        public Car(int doorsCount, EngineType engine, GearBoxType gearbox, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount) 
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            DoorsCount = doorsCount;
            Engine = engine;
            GearBox = gearbox;
        }
    }

    enum EngineType
    {
        Patrol,
        Diesel,
        Electro
    }

    enum GearBoxType
    {
        Manual,
        Auto,
        Robot
    }
}
