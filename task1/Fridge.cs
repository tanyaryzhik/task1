using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public delegate void FridgeStateEventHandler(object sender, FridgeHandlerEventArgs args);

    public class Fridge
    {
        public State FridgeState { get; set; }

        public Door FridgeDoor { get; set; }

        public string ActionMessage { get; set; }

        public event FridgeStateEventHandler FridgeStateChangedEvent;

        public Fridge()
        {
            this.ActionMessage = string.Empty;
        }

        public void GetFridgeState()
        {
            Console.WriteLine($"Fridge is {this.FridgeState} and {this.FridgeDoor} is open");
        }

        public void OpenDoor()
        {
            Console.WriteLine("What door to open R or F?");
            string door = Console.ReadLine();
            if (door == "R")
            {
                this.FridgeDoor = Door.RegularCamera;
                this.ActionMessage = "Door of regular camera has been opened\n";
            }
            if (door == "F")
            {
                this.FridgeDoor = Door.FreezerCamera;
                this.ActionMessage = "Door of freezer camera has been opened\n";
            }
            OnStateChanged(new FridgeHandlerEventArgs(this.FridgeState, this.FridgeDoor, this.ActionMessage));
            GetFridgeState();
        }

        public void TurnOffFridge()
        {
            this.FridgeState = State.TurnOff;
            this.ActionMessage = "Fridge has been turned off\n";
            OnStateChanged(new FridgeHandlerEventArgs(this.FridgeState, this.FridgeDoor, this.ActionMessage));
            GetFridgeState();
        }

        public void TurnOnFridge()
        {
            this.FridgeState = State.TurnOn;
            this.ActionMessage = "Fridge has been turned on\n";
            OnStateChanged(new FridgeHandlerEventArgs(this.FridgeState,this.FridgeDoor, this.ActionMessage));
            GetFridgeState();
        }

        protected virtual void OnStateChanged(FridgeHandlerEventArgs args)
        {
            if (FridgeStateChangedEvent != null)
                FridgeStateChangedEvent(this, args);
        }
    }
}
