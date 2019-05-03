using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public struct Train
    {
        private string destination;

        private int trainNumber;

        private DateTime departureTime;

        public Train(int trainNumber, string destination, DateTime departureTime)
        {
            if (trainNumber == 0)
                throw new ArgumentException(nameof(trainNumber));

            if (string.IsNullOrWhiteSpace(destination))
                throw new ArgumentException(nameof(destination));

            this.trainNumber = trainNumber;
            this.destination = destination;
            this.departureTime = departureTime;
        }

        public int GetTrainNumber()
        {
            return this.trainNumber;
        }

        public string GetDestination()
        {
            return this.destination;
        }

        public DateTime GetDepartureTime()
        {
            return this.departureTime;
        }
    }
}

