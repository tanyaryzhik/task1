using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = new int[10000000];
            int[] secondArr = new int[10000000];
            Random ran = new Random(); // Объект для генерации случайных чисел
            for (int i = 0; i < firstArr.Length; i++) // Заполнение массива случайными значениями в диапазоне от 1 до 100
            {
                firstArr[i] = ran.Next(1, 100);
                secondArr[i] = ran.Next(1, 100);
            }
            long firstArrSum = 0; // Сумма первого массива
            long secondArrSum = 0; // Сумма второго массива
            Task<long>[] tasks = new Task<long>[2];
            Stopwatch sw = new Stopwatch(); // Объект для подсчета времени выполнения подсчета
            sw.Start();
            tasks[0] = Task.Factory.StartNew(() => firstArrSum = CountArraySum(firstArr));
            tasks[1] = Task.Factory.StartNew(() => secondArrSum = CountArraySum(secondArr));
            //foreach (int item in firstArr) // Подсчет суммы элементов первого массива
            //{
            //    firstArrSum += item;
            //}
            //foreach (int item in secondArr) // Подсчет суммы элементов второго массива
            //{
            //    secondArrSum += item;
            //}
            sw.Stop();
            Console.WriteLine("Сумма элементов первого массива: " + tasks[0].Result);
            Console.WriteLine("Сумма элементов второго массива: " + tasks[1].Result);
            Console.WriteLine("Время выполнения подсчета: " + sw.ElapsedMilliseconds + " миллисекунд");
        }

        public static long CountArraySum(int[] array)
        {
            long sum = 0;
            foreach (int item in array) // Подсчет суммы элементов второго массива
            {
                sum += item;
            }
            return sum;
        }
    }
}
