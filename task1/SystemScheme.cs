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
        //private const string path = "C:\\Users\\user\\Documents";

        public void Execute()
        {
            int counter = 0;
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var item in dir.GetDirectories())
            {
                counter++;
            }
            long size = 0;
            size = GetDirectorySize(path, size);
            //FileInfo[] files = dir.GetFiles();
            //foreach (var item in files)
            //{
            //    size += item.Length;
            //}
            Console.WriteLine($"Number of directories is {counter}. Size: {size}");
        }

        private long GetDirectorySize(string directoryPath, long size)
        {
            DirectoryInfo dir = new DirectoryInfo(directoryPath);
            try
            {
                if (Directory.GetDirectories(directoryPath).Length == 0)
                {
                    foreach (FileInfo item in dir.GetFiles())
                    {
                        size += item.Length;
                    }
                }
                else
                    foreach (var item in Directory.GetDirectories(directoryPath))
                    {
                        Console.WriteLine(item);
                        size += GetDirectorySize(item, size);
                    }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return size;
        }
    }
}
