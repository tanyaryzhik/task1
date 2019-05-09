using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Animals
{
    class Feeder
    {
        public void Feed(Mammal[] mammals)
        {
            Random random = new Random(100);

            foreach (var item in mammals)
            {
                item.Eat(random.Next(1, 50));
                Console.WriteLine($"Animal's weight is {item.Weight} after feeding. It's age is {item.Age} months.");
            }
        }
    }
}
