using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lesson8Project1
{
    class Lesson8Project1
    {
        static void Main(string[] args)
        {
            int size = 1000000;

            List<int> list = new List<int>();

            Random random = new Random();

            for (int i = 0; i < size; i++) 
                list.Add(random.Next());

            //list.ForEach(el => Console.WriteLine(el));

            Console.WriteLine();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[] sortedArray = Sort.MySort(list);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine(elapsedTime);

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            list.Sort();
            stopwatch1.Stop();
            ts = stopwatch1.Elapsed;

            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine(elapsedTime);

            Console.ReadKey();
        }
    }
}
