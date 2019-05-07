using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Driver: Employee
    {
        private int stage;
        public int Stage
        {
            get { return stage; }
            set { stage = value; }
        }
        private Category driverCategory;
        public Category DriverCategory
        {
            get { return driverCategory; }
            set { driverCategory = value; }
        }

        public Driver(string name, int age, decimal salary, int stage, Category category) : base(name, age, salary)
        {
            Stage = stage;
            DriverCategory = category;
        }
    }

    public enum Category
    {
        A,
        B,
        C
    }
}
