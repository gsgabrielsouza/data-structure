using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using data_structure.Sort;

namespace data_structure
{
    class Program
    {
        static int[] arrayInt = null;
        private static Stopwatch watch;

        static void Main(string[] args)
        {
            CreateArray(100);

            QuickSortAlgorithm();

            Console.ReadKey();
        }

        private static void QuickSortAlgorithm()
        {
            StartWatch();

            var newArray = new QuickSort().Sort(arrayInt);

            StopWatch(nameof(QuickSort));
        }

        private static void StopWatch(string className)
        {
            watch.Stop();
            Console.WriteLine($"{className}: {watch.ElapsedMilliseconds}");
        }

        private static void StartWatch()
        {
            watch = Stopwatch.StartNew();
        }

        private static void CreateArray(int arrayLength)
        {
            var random = new Random();
            var list = new List<int>(arrayLength);
            for (int i = 0; i < arrayLength; i++)
            {
                var number = random.Next(0, arrayLength);

                while (list.Contains(number))
                    number = random.Next(0, arrayLength);

                list.Add(number);
            }
            arrayInt = list.ToArray();
        }
    }
}
