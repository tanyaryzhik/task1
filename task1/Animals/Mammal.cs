using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Animals
{
    class Mammal
    {
        private readonly int age;
        private int weight;
        private int foodAmountCount;
        public int Age
        {
            get { return age; }
        }
        public int Weight
        {
            get { return weight; }
            private set { weight = value; }
        }
        public Mammal (int age)
        {
            this.age = age;
            Weight = 1;
        }

        public void Eat(int foodAmount)
        {
            if (Age <= 12)
                Console.WriteLine("Feed animal with milk");
            else
                Console.WriteLine("Feed animal with food for adults");

            foodAmountCount = foodAmountCount + foodAmount;
            Weight = Weight + foodAmountCount / 5;
            foodAmountCount = foodAmountCount % 5;
        }
    }
}
