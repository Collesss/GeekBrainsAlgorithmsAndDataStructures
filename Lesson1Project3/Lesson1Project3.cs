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

            public override string ToString() => $"F: {F}; Expected: {Expected};";
        }

        static void Test(TestCase testCase)
        {
            int actual = 0;

            try
            {
                actual = Fibonaci(testCase.F);

                if (actual == testCase.Expected)
                    Console.WriteLine($"VALID TEST actual: {actual}; {testCase}");
                else
                    Console.WriteLine($"INVALID TEST actual: {actual}; {testCase}");
            }
            catch (Exception)
            {
                if (testCase.ExpectedException != null)
                    Console.WriteLine($"VALID TEST actual: {actual}; {testCase}");
                else
                    Console.WriteLine($"INVALID TEST actual: {actual}; {testCase}");
            }
        }

        static void Main(string[] args)
        {
            Test(new TestCase() { F = 3, Expected = 3 });
            Test(new TestCase() { F = 4, Expected = 5 });
            Test(new TestCase() { F = 5, Expected = 8 });
            Test(new TestCase() { F = 6, Expected = 13 });


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
