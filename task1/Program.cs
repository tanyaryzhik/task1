using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Animals;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Arboreal arborealBaby = new Arboreal(2);
            Arboreal arborealAdult = new Arboreal(25);
            Aquatic aquaticBaby = new Aquatic(4);
            Aquatic aquaticAdult = new Aquatic(38);
            Arial arialBaby = new Arial(1);
            Arial arialAdult = new Arial(51);
            Subterranean subterraneanBaby = new Subterranean(8);
            Subterranean subterraneanAdult = new Subterranean(41);
            Terrestrial terrestrialBaby = new Terrestrial(5);
            Terrestrial terrestrialAdult = new Terrestrial(27);
            Mammal[] mammals = new Mammal[] { arborealBaby, arborealAdult , aquaticBaby,
                aquaticAdult , arialBaby , arialAdult , subterraneanBaby , subterraneanAdult, terrestrialBaby,terrestrialAdult};
            Feeder feeder = new Feeder();
            feeder.Feed(mammals);
        }
    }
}
