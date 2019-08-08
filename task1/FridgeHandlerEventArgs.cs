using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class FridgeHandlerEventArgs : EventArgs
    {
        public State FridgeState { get; set; }

        public Door FridgeDoor { get; set; }

        public string ActionMessage { get; set; }

        public FridgeHandlerEventArgs(State state, Door door, string message)
        {
            this.FridgeDoor = door;
            this.FridgeState = state;
            this.ActionMessage = message;
        }
    }
}
