using System;

namespace Lesson3Project1
{
    class Lesson3Project1
    {
        static void Main(string[] args)
        {
            PointClass pc1 = new PointClass() { x = 1, y = 2 };
            PointClass pc2 = new PointClass() { x = 10, y = 20 };
            
            PointStructFloat pf1 = new PointStructFloat() { x = 1, y = 2 };
            PointStructFloat pf2 = new PointStructFloat() { x = 10, y = 20 };

            PointStructDouble pd1 = new PointStructDouble() { x = 1, y = 2 };
            PointStructDouble pd2 = new PointStructDouble() { x = 10, y = 20 };

            Console.WriteLine(Point.Distance(pc1, pc2));
            Console.WriteLine(Point.Distance(pf1, pf2));
            Console.WriteLine(Point.Distance(pd1, pd2));
            Console.WriteLine(Point.SqrDistance(pf1, pf2));
            Console.ReadKey();
        }
    }
}
