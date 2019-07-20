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

        public FridgeHandlerEventArgs(State state, Door door)
        {
            this.FridgeDoor = door;
            this.FridgeState = state;
        }
    }
}
