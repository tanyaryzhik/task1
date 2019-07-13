using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Ping
    {
        public event EventHandler EventPing;

        protected virtual void OnPing(EventArgs e)
        {
            this.EventPing?.Invoke(this, e);
        }

        public void DoPing()
        {
            Console.WriteLine("Ping");
            System.Threading.Thread.Sleep(1000);
            this.OnPing(new EventArgs());
         }
    }
}
