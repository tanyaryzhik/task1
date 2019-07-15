using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunting
{
    public class Hunter
    {
        private Hare hare;

        public Hunter(Hare hare)
        {
            this.hare = hare;
            this.hare.LocationChangedEvent += Catch;
        }

        public void Catch(object sender, LocationChangedEventArgs args)
        {
            Console.WriteLine($"Hare moved to X: {args.coordX} and Y: {args.coordY}");
        }
    }
}
