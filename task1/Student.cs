using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Student : User
    {
        private decimal scolarship;
        public decimal Scolarship
        {
            get { return scolarship; }
            set { scolarship = value; }
        }
        private int course;
        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public Student (string name,int age, decimal scolarship, int course):base(name,age)
        {
            Scolarship = scolarship;
            Course = course;
        }
    }
}
