using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongCustom
{
    public class Pong
    {
        public event PingPongEventHandler EventPong;

        protected virtual void OnPong(PingPongEventArgs e)
        {
            this.EventPong?.Invoke(e);
        }

        public void DoPong()
        {
            Console.WriteLine("Pong");
            System.Threading.Thread.Sleep(1000);
            this.OnPong(new PingPongEventArgs(DateTime.Now));
        }
    }
}
