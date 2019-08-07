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
        public const int WindowHeight = 40;

        public const int WindowWidth = 100;

        private int chainLength;

        private int tempChainLength;

        private int coordX;

        private int coordY;

        private Random random;

        public object locker;

        private ConsoleColor color;

        private void SetChainLength()
        {
            this.chainLength = new Random().Next(5, 10);
        }

        public void SetCoordX(int shift)
        {
            this.coordX = shift;
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
                Console.SetCursorPosition(this.coordX, this.coordY + i);
                Console.ForegroundColor = SetSymbolColor(i);
                Console.WriteLine((char)this.random.Next(33, 122));
            }
        }

        public ConsoleColor SetSymbolColor(int i)
        {
            
            if (this.coordY + this.tempChainLength < WindowHeight)
            {
                if (i == this.chainLength - 1)
                    this.color = ConsoleColor.White;
                else if (i == this.chainLength - 2)
                    this.color = ConsoleColor.Green;
                else
                    this.color = ConsoleColor.DarkGreen;
            }
            else if (this.tempChainLength > this.chainLength)
            {
                if (this.tempChainLength - this.chainLength == 1)
                {
                    if (i == this.chainLength - 1)
                        this.color = ConsoleColor.Green;
                    else
                        this.color = ConsoleColor.DarkGreen;
                }
                else
                    this.color = ConsoleColor.DarkGreen;
            }
            
            return this.color;
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

                        if (this.chainLength !=0)
                            DrawChain();
                        
                        if (this.coordY > SymbolChain.WindowHeight)
                        {
                            this.coordY = 0;
                            i = 0;
                            this.SetChainLength();
                            continue;
                        }
                        Thread.Sleep(random.Next(3000));
                        Console.SetCursorPosition(this.coordX, this.coordY);
                        Console.Write(" ");
                        this.coordY++;
                    }
                }
            }
        }
    }
}
