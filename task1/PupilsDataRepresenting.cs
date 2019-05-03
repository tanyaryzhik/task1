using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class PupilsDataRepresenting
    {
        private Pupil[] pupilsList;

        private const int pupilsMaxNumber = 5;

        public PupilsDataRepresenting()
        {
            this.pupilsList = new Pupil[pupilsMaxNumber];
        }

        private Pupil GetNewPupil()
        {
            string firstName = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter pupil's first name");
                firstName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(firstName))
                    break;
            }

            string lastName = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter pupil's last name");
                lastName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lastName))
                    break;
            }

            DateTime birthdate;
            while (true)
            {
                Console.WriteLine("Enter pupil's birthday date");

                if (DateTime.TryParse(Console.ReadLine(), out birthdate))
                    break;
            }

            string form = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter pupil's form");
                form = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(form))
                    break;
            }

            int schoolNumber = 0;
            while (true)
            {
                Console.WriteLine("Enter the number of school");
                if (int.TryParse(Console.ReadLine(), out schoolNumber))
                    break;
            }

            Pupil pupil = new Pupil(firstName, lastName, birthdate);
            pupil.Form = form;
            pupil.SchoolNumber = schoolNumber;
            return pupil;
        }

        public void Execute()
        {
            for (int i = 0; i < PupilsDataRepresenting.pupilsMaxNumber; i++)
            {
                this.pupilsList[i] = this.GetNewPupil();
            }
            DisplayDataTable(pupilsList);
        }

        private void DisplayDataTable(Pupil[] pupilsList)
        {
            string result = string.Empty;
            Console.WriteLine(String.Format("{0,20 } {1,10 } {2,10 } {3,10 } {4,10 } \n\n", "Pupil", "Birth year", "Age", "School", "Form"));
            for (int i = 0; i < PupilsDataRepresenting.pupilsMaxNumber; i++)
            {
                result = String.Format("{0,20 } {1,10 } {2,10 } {3,10 } {4,10 } \n\n", (i+1) + ". " + pupilsList[i].FirstName + " " + pupilsList[i].LastName,
                    pupilsList[i].BirthDate.Year, pupilsList[i].Age, pupilsList[i].SchoolNumber, pupilsList[i].Form);
                Console.WriteLine(result);
            }
        }
    }
}
