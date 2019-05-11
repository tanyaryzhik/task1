using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.PlantsTask
{
    internal class Worker
    {
        public void Care(int waterAmount, int mineralAmount, Plant plant)
        {
            plant.Drink(waterAmount);
            plant.Eat(mineralAmount);
            plant.Breath(waterAmount, mineralAmount);
        }
    }
}
