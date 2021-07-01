using System;

namespace Lesson1Project3
{
    class Lesson1Project3
    {
        public class TestCase
        {
            public int F { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        static void Test(TestCase testCase)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Fibonaci(3));
            Console.WriteLine(Fibonaci(4));
            Console.WriteLine(Fibonaci(5));
            Console.WriteLine(Fibonaci(6));

            Console.ReadKey();
        }

        static int Fibonaci(int i)
        {
            if (i < 0)
                return 0;
            else if (i <= 1)
                return 1;

            return Fibonaci(i - 1) + Fibonaci(i - 2);
        }
    }
}
