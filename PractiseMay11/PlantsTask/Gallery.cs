using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.PlantsTask
{
    internal class Gallery
    {
        private Plant[] plants;

        private Worker worker;

        public Gallery(Plant[] plants, Worker worker)
        {
            if (plants.Any<Plant>())
                this.plants = plants;
            else
                throw new ArgumentNullException();
            if (worker != null)
                this.worker = worker;
            else
                throw new ArgumentNullException();
        }

        public void Execute()
        {
            Random random = new Random(10);
            foreach (var item in plants)
            {
                worker.Care(random.Next(1, 10), random.Next(1, 10), item);
                if (item is Flower flower)
                {
                    flower = item as Flower;
                    flower.Scent(random.Next(10));
                }
                if (item is Tree tree)
                {
                    tree = item as Tree;
                    tree.CreateShadow(random.Next(10));
                }
            }
        }
    }
}
