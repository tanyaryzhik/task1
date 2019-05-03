using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //TaskMethods.GetCalculation();
            //TaskMethods.ConvertCurrency();
            //TaskMethods.GetCreditCondition();
            //TaskMethods.Validation();
            //TaskMethods.UniteStrings();
            //TaskMethods.TransformString();
            //TaskMethods.TaskWithTriangle();
            new PupilsDataRepresenting().Execute();
            Console.ReadLine();
        }

        public static decimal PerformCalculation(int r)
        {
            const decimal Pi = 3.14m;
            decimal square = Pi * r * r;
            return square;
        }
    }
}
