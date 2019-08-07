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

        private static object locker;

        public Executer()
        {
            locker = new object();
            this.symbolChains = new SymbolChain[2];
            for (int i = 0; i < 2; i++)
            {
                symbolChains[i] = new SymbolChain();
                symbolChains[i].SetCoordX(i*10);
            }
        }

        public void Run()
        {
            Task[] tasks = new Task[2];
            for (int i = 0; i < tasks.Length; i++)
            {
                //Task t = new Task(symbolChains[i].MoveChain);
                //Task t = Task.Run(() => symbolChains[i].MoveChain());
                
                    tasks[i] = Task.Factory.StartNew(() => symbolChains[i].MoveChain());
                
            }
            
        }
    }
}
