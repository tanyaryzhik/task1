using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongCustom
{
    public class Ping
    {
        public event PingPongEventHandler EventPing;

        protected virtual void OnPing(PingPongEventArgs e)
        {
            this.EventPing?.Invoke(e);
        }

        public void DoPing()
        {
            Console.WriteLine("Ping");
            System.Threading.Thread.Sleep(1000);
            this.OnPing(new PingPongEventArgs(DateTime.Now));
        }
    }
}
