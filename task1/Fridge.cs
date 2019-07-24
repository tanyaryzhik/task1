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
                Console.WriteLine("Door of regular camera has been opened");
            }
            if (door == "F")
            {
                this.FridgeDoor = Door.FreezerCamera;
                Console.WriteLine("Door of freezer camera has been opened");
            }
            OnStateChanged(new FridgeHandlerEventArgs(this.FridgeState, this.FridgeDoor));
        }

        public void TurnOffFridge()
        {
            this.FridgeState = State.TurnOff;
            Console.WriteLine("Fridge has been turned off");
            OnStateChanged(new FridgeHandlerEventArgs(this.FridgeState, this.FridgeDoor));
        }

        public void TurnOnFridge()
        {
            this.FridgeState = State.TurnOn;
            Console.WriteLine("Fridge has been turned on");
            OnStateChanged(new FridgeHandlerEventArgs(this.FridgeState,this.FridgeDoor));
        }

        public event FridgeStateEventHandler FridgeStateChangedEvent;

        protected virtual void OnStateChanged(FridgeHandlerEventArgs args)
        {
            if (FridgeStateChangedEvent != null)
                FridgeStateChangedEvent(this, args);
        }
    }

    public enum State
    {
        TurnOff = 0,
        TurnOn = 1
    }

    public enum Door
    {
        RegularCamera = 0,
        FreezerCamera = 1
    }
}
