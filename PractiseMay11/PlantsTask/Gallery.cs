using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.PlantsTask
{
    internal class Gallery
    {
        public Plant[] plants;

        public Worker worker;

        public Gallery(Plant[] plants, Worker worker)
        {
            this.plants = plants;
            this.worker = worker;
        }

        public void Execute()
        {
            Random random = new Random(10);
            foreach (var item in plants)
            {
                worker.Care(random.Next(1, 10), random.Next(1, 10), item);
            }
        }
    }
}
