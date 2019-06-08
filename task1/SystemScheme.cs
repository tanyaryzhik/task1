using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticeJune8
{
    public class SystemScheme
    {
        private const string path = "C:\\Windows\\System32";

        public void Execute()
        {
            int counter = 0;
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var item in dir.GetDirectories())
            {
                counter++;
            }
            FileInfo[] files  = dir.GetFiles();
            long size = 0;
            foreach (var item in files)
            {
                size += item.Length;
            }
            Console.WriteLine($"Number of directories is {counter}. Size: {size}");
        }
    }
}
