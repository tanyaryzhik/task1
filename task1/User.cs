using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class User
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public User (string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
