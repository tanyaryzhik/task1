using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Matrix
{
    public class Executer
    {
        private SymbolChain[] symbolChains;

        public Executer()
        {
            this.symbolChains = new SymbolChain[10];
            for (int i = 0; i < 10; i++)
            {
                symbolChains[i] = new SymbolChain();
                symbolChains[i].SetCoordX(i);
            }
        }

        public void Run()
        {
            Task[] tasks = new Task[10];
            for (int i = 0; i < tasks.Length; i++)
            {
                //Task t = new Task(symbolChains[i].MoveChain);
                //Task t = Task.Run(() => symbolChains[i].MoveChain());
                tasks[i] = Task.Factory.StartNew(() => symbolChains[i].MoveChain());
            }
            
        }
    }
}
