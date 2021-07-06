using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3Project1
{
    public static class Point
    {
        public static float Distance(PointClass p1, PointClass p2) => MathF.Sqrt(MathF.Pow(p2.x - p1.x, 2) + MathF.Pow(p2.y - p1.y, 2));
        public static float Distance(PointStructFloat p1, PointStructFloat p2) => MathF.Sqrt(MathF.Pow(p2.x - p1.x, 2) + MathF.Pow(p2.y - p1.y, 2));
        public static double Distance(PointStructDouble p1, PointStructDouble p2) => Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        public static float SqrDistance(PointStructFloat p1, PointStructFloat p2) => MathF.Pow(p2.x - p1.x, 2) + MathF.Pow(p2.y - p1.y, 2);
    }
}
