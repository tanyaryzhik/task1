using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunting
{
    public delegate void LocationChangedDelegate(object sender, LocationChangedEventArgs args);

    public class Hare
    {
        private double coordX;

        private double coordY;

        public event LocationChangedDelegate LocationChangedEvent;

        protected virtual void OnLocationChanged(LocationChangedEventArgs args)
        {
            if (LocationChangedEvent !=null)
            LocationChangedEvent(this, args);
        }

        public void Move()
        {
            this.coordX = new Random(2).Next(10);
            this.coordY = new Random().Next(10);
            OnLocationChanged(new LocationChangedEventArgs(this.coordX, this.coordY));
        }
    }
}
