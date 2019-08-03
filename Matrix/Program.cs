using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Executer().Run();
            //new SymbolChain().MoveChain();
            SymbolChain[] symbolChains = new SymbolChain[2];
            for (int i = 0; i < 2; i++)
            {
                symbolChains[i] = new SymbolChain();
                symbolChains[i].SetCoordX(i);
            }

            for (int i = 0; i < symbolChains.Length; i++)
            {
                Thread t = new Thread(symbolChains[i].MoveChain);
                t.Start();
            }
        }
    }
}
