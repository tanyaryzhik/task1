using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class FridgeManager
    {
        public Fridge Fridge { get; set; }
        public FridgeManager(Fridge fridge)
        {
            this.Fridge = fridge;
            this.Fridge.FridgeStateChangedEvent += ManageFridgeState;
        }

        public void ManageFridgeState(object sender, FridgeHandlerEventArgs args)
        {
            this.Fridge.GetFridgeState();
        }

        public void Execute()
        {
            this.Fridge.TurnOnFridge();
            this.Fridge.OpenDoor();
            this.Fridge.TurnOffFridge();
        }
    }
}
