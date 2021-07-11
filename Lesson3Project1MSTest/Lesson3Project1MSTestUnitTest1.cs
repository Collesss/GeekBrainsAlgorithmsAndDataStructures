using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson3Project1;

namespace Lesson3Project1MSTest
{
    [TestClass]
    public class Lesson3Project1MSTestUnitTest1
    {
        [TestMethod]
        public void TestMethodDistancePointClass1()
        {
            float expected = 20.12461f;

            PointClass pc1 = new PointClass() { x = 1, y = 2 };
            PointClass pc2 = new PointClass() { x = 10, y = 20 };

            float distance = Point.Distance(pc1, pc2);

            Assert.AreEqual(expected, distance, 0.001f, "ќшибка в расчЄтах.");
        }

        [TestMethod]
        public void TestMethodDistancePointStructFloat2()
        {
            float expected = 20.12461f;

            PointStructFloat pc1 = new PointStructFloat() { x = 1, y = 2 };
            PointStructFloat pc2 = new PointStructFloat() { x = 10, y = 20 };

            float distance = Point.Distance(pc1, pc2);

            Assert.AreEqual(expected, distance, 0.001f, "ќшибка в расчЄтах.");
        }

        [TestMethod]
        public void TestMethodDistancePointStructDouble3()
        {
            double expected = 20.12461179749811;

            PointStructDouble pc1 = new PointStructDouble() { x = 1, y = 2 };
            PointStructDouble pc2 = new PointStructDouble() { x = 10, y = 20 };

            double distance = Point.Distance(pc1, pc2);

            Assert.AreEqual(expected, distance, 0.001, "ќшибка в расчЄтах.");
        }

        [TestMethod]
        public void TestMethodDistancePointStructFloatSqrDistance4()
        {
            float expected = 405;

            PointStructFloat pc1 = new PointStructFloat() { x = 1, y = 2 };
            PointStructFloat pc2 = new PointStructFloat() { x = 10, y = 20 };

            float distance = Point.SqrDistance(pc1, pc2);

            Assert.AreEqual(expected, distance, 0.001f, "ќшибка в расчЄтах.");
        }
    }
}
