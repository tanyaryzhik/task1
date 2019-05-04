using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Moto : Vehicle
    {
        public MotoType Motocycle { get; set; }
        
        public Moto(MotoType motocycle, int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            Motocycle = motocycle;
        }
    }


    enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        Enduro
    }
}
