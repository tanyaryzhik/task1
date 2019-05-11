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

        }
    }
}
