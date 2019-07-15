using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongCustom
{
    public delegate void PingPongEventHandler(PingPongEventArgs e);

    public class CustomPlayer
    {
        public Ping Ping { get; set; }

        public Pong Pong { get; set; }

        public CustomPlayer()
        {
            this.Ping = new Ping();
            this.Pong = new Pong();
            this.Ping.EventPing += this.OnPingInvoked;
            this.Pong.EventPong += this.OnPongInvoked;

        }

        public void Play()
        {
            this.Pong.DoPong();
        }

        public void OnPingInvoked(PingPongEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.Pong.DoPong();
        }
        public void OnPongInvoked(PingPongEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.Ping.DoPing();
        }
    }
}
