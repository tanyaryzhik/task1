using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{

    public delegate void KeyPressDelegate(object sender, KeyPressEventArgs e);

    public class Key
    {
        private ConsoleKeyInfo keyInfo;

        public event KeyPressDelegate KeyPressEvent;

        protected virtual void OnKeyPress(KeyPressEventArgs e)
        {
            this.KeyPressEvent?.Invoke(this, e);
        }

        public void StartReadKey()
        {
            while (true)
            {
                this.keyInfo = Console.ReadKey(true);
                
                this.OnKeyPress(new KeyPressEventArgs(this.keyInfo));
            }
        }

        
    }
}
