using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.PlantsTask
{
    internal class Flower : Plant
    {
        public int burgeonAmount;

        public Flower(string type, int height, int burgeons)
            : base(type, height)
        {
            this.burgeonAmount = burgeons;
        }

        public void Scent(int burgeons)
        {
            if (burgeons < 5)
                Console.WriteLine("Scent is week");
            if (burgeons > 5)
                Console.WriteLine("Scent is strong");
        }
    }
}
