using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class TrainSchedule
    {
        private const int TrainsMaxNumber = 2;

        private Train[] trainList;

        public TrainSchedule()
        {
            this.trainList = new Train[TrainsMaxNumber];
        }

        private void DisplayTrainInfo(int trainNumber)
        {
            Train selectedTrain = new Train();
            for (int i = 0; i < TrainSchedule.TrainsMaxNumber; i++)
            {
                if (this.trainList[i].GetTrainNumber() == trainNumber)
                    selectedTrain = this.trainList[i];
            }

            if (selectedTrain.GetTrainNumber() == 0)
            {
                Console.WriteLine($"Train number {trainNumber} was not found in this list");
                return;
            }
            Console.WriteLine($"Train {trainNumber} is departuring to {selectedTrain.GetDestination()}at {selectedTrain.GetDepartureTime()}");
        }

        private Train GetNewTrain()
        {
            int number = 0;
            while (true)
            {
                Console.WriteLine("Enter the number of train");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
            }

            DateTime departureTime;
            while (true)
            {
                Console.WriteLine("Enter the time of departure of train");
                if (DateTime.TryParse(Console.ReadLine(), out departureTime))
                    break;
            }

            string destination = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter destination");
                destination = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(destination))
                    break;
            }

            return new Train(number, destination, departureTime);
        }

        public void Execute()
        {
            for (int i = 0; i < TrainSchedule.TrainsMaxNumber; i++)
            {
                this.trainList[i] = this.GetNewTrain();
            }

            int selectedTrainNumber = this.AskTrainNumber();

            this.DisplayTrainInfo(selectedTrainNumber);
        }

        private int AskTrainNumber()
        {
            int number = 0;
            while (true)
            {
                Console.WriteLine("Enter the number of train");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
            }
            return number;
        }
    }
}