using Sortings;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Work();
            Console.Read();
        }

        static void Work()
        {
            var countOfArrays = 10;
            var countOfElements = 10000;
            List<int[]> list = new List<int[]>();
            for (var iteration = 0; iteration < countOfArrays; iteration++)
            {
                list.Add(CreateArray(countOfElements));
            }
            MeasureActionTime(list, (a) =>
            {
                a.BubbleSort();
            });
        }

        static int[] CreateArray(int countOfElements)
        {
            var array = new int[countOfElements];
            var random = new Random();
            for (var position = 0; position < countOfElements; position++)
            {
                array[position] = random.Next(int.MinValue, int.MaxValue);
            }
            return array;
        }

        static void MeasureActionTime(List<int[]> arrays, Action<int[]> action)
        {
            var sw = new Stopwatch();
            Console.WriteLine("Begin measure..");
            sw.Start();

            arrays.ForEach(action);

            sw.Stop();
            Console.WriteLine($"The end of action. Time of execution: {sw.ElapsedMilliseconds / 1000.0} sec.");
        }
    }
}
