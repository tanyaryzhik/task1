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
        static int WindowHeight = 25;

        static int WindowWidth = 100;

        static object locker1 = new object();

        //object locker2 = new object();

         public Executer()
        {
            Console.WindowHeight = WindowHeight;
            Console.WindowWidth = WindowWidth;
        }

        public void Run()
        {
            Task[] tasks = new Task[2]
            {
                new Task(() => MoveChain(0, 0, SetChainLength())),
                new Task(() => MoveChain(1, 0, SetChainLength()))
            };

            //for (int i = 0; i < 2; i++)
            //{
            //    tasks[i] = new Task(() => MoveChain(i, 0, SetChainLength()));
            //    //tasks[i] = Task.Factory.StartNew(() => MoveChain(i, 0, SetChainLength()));
            //}
            foreach (var item in tasks)
            {
                item.Start();
            }
         }

        private void DrawChain(int coordX, int coordY, int chainLength, ColorCondition colorCondition)
        {
            lock (Console.Out)
            {
                Random random = new Random();
                for (int i = 0; i < chainLength; i++)
                {
                    Console.SetCursorPosition(coordX, coordY + i);
                    Console.ForegroundColor = SetSymbolColor(i, chainLength, coordY, colorCondition);
                    Console.WriteLine((char)random.Next(33, 122));
                }
            }
        }

        public ConsoleColor SetSymbolColor(int i, int chainLength, int coordY, ColorCondition colorCondition)
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

        public void MoveChain(int coordX, int coordY, int chainLength)
        {
            lock (Console.Out)
            {
                while (true)
                {
                    ColorCondition colorCondition = ColorCondition.Long;
                    for (int i = 0; i < WindowHeight; i++)
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
                        Thread.Sleep(1000);
                        Console.SetCursorPosition(coordX, coordY);
                        Console.Write(" ");
                        coordY++;
                    }
                }
            }
        }
    

        public int SetChainLength()
        {
            return new Random().Next(3, 10);
        }
    }
}

    public enum ColorCondition
    {
        Long = 0,
        Shorter = 1,
        Short = 2
    }
