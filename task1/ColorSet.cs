using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class ColorSet
    {
        public Color color;
        public void Print(string text, string color)
        {
            Console.ForegroundColor = DetectColor(color);
            Console.WriteLine(text);
        }

        private ConsoleColor DetectColor(string color)
        {
            ConsoleColor checkedColor = ConsoleColor.White;
            switch (color)
            {
                case "Red":
                    checkedColor = ConsoleColor.Red;
                    break;
                case "Yellow":
                    checkedColor = ConsoleColor.Yellow;
                    break;
                case "Green":
                    checkedColor = ConsoleColor.Green;
                    break;
                case "Blue":
                    checkedColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.WriteLine("Invalid color input");
                    break;
            }
            return checkedColor;
        }
    }
}
