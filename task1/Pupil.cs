using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Pupil
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }
        public int SchoolNumber { get; set; }
        public string Form { get; set; }
        
        public Pupil(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthdate;
            Age = DateTime.Now.Year - birthdate.Year;
        }
    }
}
