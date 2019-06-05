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

            Console.WriteLine("Choose state for switchers, write On or Off");
            Console.WriteLine($"What do you want to do?");
            while (isAnswerInvalid)
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
            }
            switch (chosenState)
            {
                case "On":
                    if (!CheckState(lamp))
                        lamp.TurnOn();
                    else
                        Console.WriteLine($"{lamp.Name} is already turned on");
                    if (!CheckState(iron))
                        iron.TurnOn();
                    else
                        Console.WriteLine($"{iron.Name} is already turned on");
                    break;
                case "Off":
                    if (CheckState(lamp))
                        lamp.TurnOff();
                    else
                        Console.WriteLine($"{lamp.Name} is already turned off");
                    if (CheckState(iron))
                        iron.TurnOff();
                    else
                        Console.WriteLine($"{iron.Name} is already turned off");
                    break;
            }
        }

        private bool CheckState(ISwitchable switchableApp)
        {
            bool turnOn = false;

            if (switchableApp is Lamp lamp)
            {
                lamp = (Lamp)switchableApp;
                if (lamp.StateOfLamp == State.Off)
                    turnOn = false;
                else
                    turnOn = true;
            }

            if (switchableApp is ElectricalAppliance elApp)
            {
                elApp = (ElectricalAppliance)switchableApp;
                if (elApp.StateOfElApp == State.Off)
                    turnOn = false;
                else
                    turnOn = true;
            }

            return turnOn;
        }
    }
}
