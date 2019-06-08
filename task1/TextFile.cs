using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeJune8
{
    public class TextFile
    {
        private string path = "C:\\Temp\\";

        public void Execute()
        {
            Directory.CreateDirectory(path);
            path = path + "UserText.txt";
            Console.WriteLine("Enter some text");
            string text = Console.ReadLine();
            File.AppendAllText(path, text);
        }
    }
}
