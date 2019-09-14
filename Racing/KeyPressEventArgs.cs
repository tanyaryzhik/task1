using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    

    public class KeyPressEventArgs : EventArgs
    {
        public ConsoleKeyInfo KeyInfo { get; set; }

        public KeyPressEventArgs(ConsoleKeyInfo keyInfo)
        {
            this.KeyInfo = keyInfo;
        }
    }
}
