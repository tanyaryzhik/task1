using PractiseJune14.SingleLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseJune14
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = DateTime.Now;
            //Console.WriteLine($"{date.Month} {date.Day} {date.Year}");
            //Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            //DateTime yesterday = DateTime.Now.AddDays(-1);
            //Console.WriteLine(yesterday);
            //DateTime twoMonthsBefore = DateTime.Now.AddMonths(-2);
            //Console.WriteLine(twoMonthsBefore);
            //DateTime oneYearBefore = DateTime.Now.AddYears(-1);
            //Console.WriteLine(oneYearBefore);
            //DateTime birthday = new DateTime(1981, 1, 14);
            //Console.WriteLine(birthday);

            //MyList<int> myList = new MyList<int> ();
            //myList.Add(1);
            //myList.Add(3);
            //myList.Add(5);
            //myList.Contains(2);
            //Console.WriteLine(myList[2]);
            //for (int i = 0; i < myList.Count; i++)
            //{
            //    Console.WriteLine(myList[i]);
            //}
            //Console.WriteLine(myList.ToString());

            //Car bmw = new Car { Name = "BMW", Year = 2015 };
            //Car ford = new Car { Name = "Ford", Year = 2012 };
            //CarCollection<Car> carCollection = new CarCollection<Car>();
            //carCollection.Add(bmw);
            //carCollection.Add("VW", 2013);
            //carCollection.Add("Skoda", 2009);
            //carCollection.Add(ford);
            //Car carOne = carCollection[1];
            //Car carTwo = carCollection["BMW"];
            //bool carContained = carCollection.Contains(ford);
            //int count = carCollection.Count;

            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(100);
            linkedList.Add(200);
            linkedList.Add(50);
            linkedList.Add(14);
            linkedList.Remove(200);
        }
    }
}
