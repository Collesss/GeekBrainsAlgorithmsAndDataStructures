using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2Project2
{
    class Test
    {
        public int[] array;

        public int value;

        public int valueExpected;

        private int id;

        private static int countTest = 0;

        public Test()
        {
            id = countTest++;
        }

        public void Testing()
        {
            try
            {
                int result = AlgoritmsSearch.BinarySearch(array, value);

                Console.Write($"Test {id}. \tValue: {value}. \tValue expected: {valueExpected}. \tResult: {result}. ");
                Console.ForegroundColor = result == valueExpected ? ConsoleColor.Green : ConsoleColor.Red;
                Console.Write(result == valueExpected ? "\tpassed" : "\tfailed");
                Console.ResetColor();
                Console.WriteLine($". Array: {{ {string.Join(", ", array)} }}");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Test {id}. failed Error: {e.Message}");
                Console.ResetColor();
            }
        }
    }
}
