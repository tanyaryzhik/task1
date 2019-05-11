using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMay11.PlantsTask
{
    internal class Tree : Plant
    {
        public int maxBranchLength;

        public Tree(string type, int height, int length)
            : base(type, height)
        {
            this.maxBranchLength = length;
        }

        public void CreateShadow(int length)
        {
            if (length < 1)
                Console.WriteLine("Small shadow");
            if (length >= 1)
                Console.WriteLine("Good Shadow");
        }
    }
}
