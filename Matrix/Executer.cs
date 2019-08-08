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
        private const int WindowHeight = 25;

        private const int WindowWidth = 100;

        private static object locker = new object();

        public Executer()
        {
            Console.WindowHeight = WindowHeight;
            Console.WindowWidth = WindowWidth;
        }

        public void Run()
        {
            Task[] tasks = new Task[WindowWidth];

            for (int i = 0; i < WindowWidth; i++)
            {
                tasks[i] = Task.Factory.StartNew(() => MoveChain(i, new Random().Next(0, WindowHeight / 2), SetChainLength()));
                Thread.Sleep(1000);
            }

            Task.WaitAll(tasks);
        }

        private void DrawChain(int coordX, int coordY, int chainLength, ColorCondition colorCondition)
        {
            Random random = new Random();
            for (int i = 0; i < chainLength; i++)
            {
                Console.SetCursorPosition(coordX, coordY + i);
                Console.ForegroundColor = SetSymbolColor(i, chainLength, coordY, colorCondition);
                Console.WriteLine((char)random.Next(33, 122));
            }
        }

        private ConsoleColor SetSymbolColor(int i, int chainLength, int coordY, ColorCondition colorCondition)
        {
            ConsoleColor color = ConsoleColor.Black;

            if (colorCondition == ColorCondition.Long)
            {
                if (i == chainLength - 1)
                    color = ConsoleColor.White;
                else if (i == chainLength - 2)
                    color = ConsoleColor.Green;
                else
                    color = ConsoleColor.DarkGreen;
            }

            else if (colorCondition == ColorCondition.Shorter)
            {
                if (i == chainLength - 1)
                    color = ConsoleColor.Green;
                else
                    color = ConsoleColor.DarkGreen;
            }

            else if (colorCondition == ColorCondition.Short)
                color = ConsoleColor.DarkGreen;

            return color;
        }

        private void MoveChain(int coordX, int coordY, int chainLength)
        {
            while (true)
            {
                ColorCondition colorCondition = ColorCondition.Long;

                for (int i = 0; i < WindowHeight; i++)
                {
                    Thread.Sleep(1000);
                    lock (locker)
                    {
                        if (coordY >= WindowHeight - chainLength)
                        {
                            chainLength--;

                            if (colorCondition == ColorCondition.Long)
                                colorCondition = ColorCondition.Shorter;
                            else if (colorCondition == ColorCondition.Shorter)
                                colorCondition = ColorCondition.Short;
                            else
                                colorCondition = ColorCondition.Short;
                        }

                        if (chainLength != 0)
                            DrawChain(coordX, coordY, chainLength, colorCondition);

                        if (coordY > WindowHeight)
                        {
                            coordY = 0;
                            i = 0;
                            chainLength = SetChainLength();
                            colorCondition = ColorCondition.Long;
                            continue;
                        }

                        Console.SetCursorPosition(coordX, coordY);
                        Console.Write(" ");
                        coordY++;
                    }
                }
            }
        }

        private int SetChainLength()
        {
            return new Random().Next(3, 10);
        }
    }
}