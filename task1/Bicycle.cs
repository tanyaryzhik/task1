using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Bicycle : Vehicle
    {
        public BicycleType Type { get; set; }
        public BrakeType Brake { get; set; }

        public Bicycle(BicycleType type, BrakeType brake, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            Type = type;
            Brake = brake;
        }
    }

    enum BicycleType
    {
        RoadBike,
        MountainBike,
        BMX
    }

    enum BrakeType
    {
        HandBrakes,
        FootBrakes
    }
}
