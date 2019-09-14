using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing
{
    class Program
    {
        public static object locker = new object();
        static void Main(string[] args)
        {

            Field field = new Field();
            field.Move();

        }  
    }
}
