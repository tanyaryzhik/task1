using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay18.Mammals
{
    public class Mammal
    {
        private readonly int age;

        private int weight;

        protected virtual int WeightIncrease{ get; set; }

        public int Age
        {
            get { return this.age; }
        }

        public int Weight
        {
            get { return this.weight; }
            protected set { weight = value; }
        }

        public Mammal(int age)
        {
            this.age = age;
            this.Weight = 1;
        }

        public virtual void Eat(int foodAmount)
        {
            if (this.Age <= 12)
                Console.WriteLine("Feed animal with milk");
            else
                Console.WriteLine("Feed animal with food for adults");

            this.Weight = this.Weight + this.WeightIncrease * (foodAmount / 5);
        }

        public virtual void Move()
        {
        }
    }
}
