using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    static class ColorSet
    {
        public Color color
        public static void Print(string text, string color)
        {
            Console.ForegroundColor = color.to;
            Console.WriteLine(text);
        }
    }
    enum Color
    {
        Red = ConsoleColor.Red,
        Yellow = ConsoleColor.Yellow,
        Green = ConsoleColor.Green,
        Blue = ConsoleColor.Blue,
        Magenta = ConsoleColor.Magenta
    }
}
