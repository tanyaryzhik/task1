using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, EngineType.Electro, GearBoxType.Auto, 4, ConsoleColor.DarkBlue,100, 4);
            Bicycle bicycle = new Bicycle(BicycleType.BMX, BrakeType.FootBrakes, 2, ConsoleColor.Red,60,1);
            Moto motocycle = new Moto(MotoType.Adventure, 2, ConsoleColor.Green, 100, 1);

            car.Move(500);
            bicycle.Move(100);
            motocycle.Move(10);

            car.DisplayInfo();
            bicycle.DisplayInfo();
            motocycle.DisplayInfo();
        }
    }
}
