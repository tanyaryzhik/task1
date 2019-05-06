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
            header.Append(String.Format("{0,20} {1,20} {2,20} \n\n", "DoorsCount", "Engine", "GearBox"));
            vehicleData.Append(String.Format("{0,20} {1,20} {2,20} \n\n", DoorsCount, Engine, GearBox));
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
