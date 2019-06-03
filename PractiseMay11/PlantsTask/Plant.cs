using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.PlantsTask
{
    public class Plant
    {
        public string Type { get; }

        public Color Color { get; set; }
        
        public int Height { get; set; }

        public Plant(string type, int height)
        {
            this.Type = type;
            this.Color = 0;
            this.Height = height;
        }

        public void Drink(double waterAmount)
        {
            if (waterAmount > 0)
            {
                Console.WriteLine($"Plant was poured with 0.{waterAmount}l of water");
                Console.WriteLine("Plant has grown 1cm");
                this.Height++;
            }
            else
                throw new ArgumentException();
        }

        public void Eat(double mineralAmount)
        {
            if (mineralAmount > 0)
            {
                this.Color++;
                Console.WriteLine($"Plant leaves became {this.Color}");
            }
            else
                throw new ArgumentException();
        }

        public void Breath(double waterAmount, double mineralAmount)
        {
            Eat(mineralAmount);
            Drink(waterAmount);
            Console.WriteLine("Plant has given 0.5l of oxigen");
        }
    }
}
