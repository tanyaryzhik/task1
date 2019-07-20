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
            Fridge fridge = new Fridge { FridgeDoor = Door.FreezerCamera, FridgeState = State.TurnOff };
            FridgeManager manager = new FridgeManager(fridge);
            manager.Execute();
            Console.ReadLine();
        }
    }
}
