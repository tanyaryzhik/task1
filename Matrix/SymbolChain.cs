using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Matrix
{
    public class SymbolChain
    {
        public const int WindowHeight = 25;

        public const int WindowWidth = 100;

        private int chainLength;

        private int tempChainLength;

        private int coordX;

        private int coordY;

        private Random random;

        public object locker;

        private Symbol[] symbols;

        private void SetChainLength()
        {
            this.chainLength = new Random().Next(3, 10);
        }

        public void SetCoordX(int shift)
        {
            this.coordX = shift*10;
        }


        public SymbolChain()
        {
            this.random = new Random();
            this.SetChainLength();
            this.tempChainLength = this.chainLength;
            this.coordY = 0;
            Console.WindowHeight = SymbolChain.WindowHeight;
            Console.WindowWidth = SymbolChain.WindowWidth;
            this.locker = new object();
        }

        private void DrawChain()
        {
            for (int i = 0; i < this.chainLength; i++)
            {
                SetSymbolColor();
                Console.SetCursorPosition(this.coordX, this.coordY + i);
                Console.WriteLine((char)this.random.Next(33, 122));
            }
        }

        private void DrawShortChain()
        {
            for (int i = 0; i < this.chainLength; i++)
            {
                SetSymbolColor();
                Console.SetCursorPosition(this.coordX, this.coordY + i);
                Console.WriteLine((char)this.random.Next(33, 122));
            }
        }

        public void SetSymbolColor()
        {
            if (this.tempChainLength - this.chainLength == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (i == this.chainLength - 1)
                Console.ForegroundColor = ConsoleColor.White;
            else if (i == this.chainLength - 2)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }

        public void MoveChain()
        {
            lock (locker)
            {
                while (true)
                {
                    for (int i = 0; i < SymbolChain.WindowHeight; i++)
                    {
                        if (this.coordY >= SymbolChain.WindowHeight - this.chainLength)
                        {
                            this.chainLength--;
                        }

                        DrawChain();
                        
                        if (this.coordY > SymbolChain.WindowHeight)
                        {
                            this.coordY = 0;
                            i = 0;
                            this.SetChainLength();
                            continue;
                        }
                        Thread.Sleep(random.Next(1000));
                        Console.SetCursorPosition(this.coordX, this.coordY);
                        Console.Write(" ");
                        this.coordY++;
                    }
                }
            }
        }
    }
}
