using System;

namespace Lesson2Project2
{
    class Lesson2Project2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[30];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;


            new Test() { array = arr, value = 15, valueExpected = 15 }.Testing();
            new Test() { array = arr, value = 20, valueExpected = 20 }.Testing();
            new Test() { array = arr, value = 25, valueExpected = 25 }.Testing();
            new Test() { array = arr, value = 0, valueExpected = 0 }.Testing();
            new Test() { array = arr, value = -10, valueExpected = -1 }.Testing();
            new Test() { array = arr, value = 35, valueExpected = -1 }.Testing();

            Console.ReadKey();
        }

        
    }
}
