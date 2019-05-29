using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Switcher
{
    public class Manager
    {
        public void Manage()
        {
            Lamp lamp = new Lamp("Livingroom lamp");
            ElectricalAppliance iron = new ElectricalAppliance("Iron");
            bool isAnswerInvalid = true;
            string chosenState = string.Empty;

            while (isAnswerInvalid)
            {
                Console.WriteLine("Choose state for switchers, write On or Off");
                Console.WriteLine($"What do you want to do?");
                do
                {
                    chosenState = Console.ReadLine();
                    if (chosenState == "On" || chosenState == "Off")
                    {
                        isAnswerInvalid = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Write On or Off");
                    }
                } while (true);
            }
            switch (chosenState)
            {
                case "On":
                    lamp.TurnOn();
                    iron.TurnOn();
                    break;
                case "Off":
                    lamp.TurnOff();
                    iron.TurnOff();
                    break;
            }
        }
    }
}
