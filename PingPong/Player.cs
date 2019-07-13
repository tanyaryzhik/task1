using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Player
    {
        public Ping Ping { get; set; }

        public Pong Pong { get; set; }

        public Player()
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

        public void OnPingInvoked(object sender, EventArgs e)
        {
            this.Pong.DoPong();
        }
        public void OnPongInvoked(object sender, EventArgs e)
        {
            this.Ping.DoPing();
        }
    }
}
