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
            header.Append(String.Format("{0,20} \n\n", "Motocycle"));
            vehicleData.Append(String.Format("{0,20} \n\n", Motocycle));
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
