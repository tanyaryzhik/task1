using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (MyClass instance = new MyClass())
            //{
            //    instance.ReadFile();
            //}

            //MyClass instance2 = new MyClass();
            //instance2.ReadFile();
            //instance2.Dispose();

            MyClass instance3 = new MyClass();
            instance3.ReadFile();
        }
    }
}
