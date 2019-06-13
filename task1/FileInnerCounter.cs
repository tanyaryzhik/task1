using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    public class FileInnerCounter
    {
        private const string Path = "C:\\Temp\\UserText.txt";

        public void Execute()
        {
            string text = File.ReadAllText(FileInnerCounter.Path);
            int symbolsAmount = text.Length;
            string[] strings = text.Split('\n');
            int stringsAmount = strings.Length;
            string[] words = text.Split(' ', '\n');
            int wordsAmount = words.Length;
            Console.WriteLine($"Symbols {symbolsAmount}, strings {stringsAmount}, words {wordsAmount}");
        }
    }
}
