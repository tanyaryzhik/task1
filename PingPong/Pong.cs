using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Pong
    {
        public event EventHandler EventPong;

        protected virtual void OnPong(EventArgs e)
        {
            this.EventPong?.Invoke(this, e);
        }

        public void DoPong()
        {
            Console.WriteLine("Pong");
            System.Threading.Thread.Sleep(1000);
            this.OnPong(new EventArgs());
        }
    }
}
