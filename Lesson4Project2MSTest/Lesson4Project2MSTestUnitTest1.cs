using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lesson4Project2;
using System.Reflection;
using System.Collections.Generic;

namespace Lesson4Project2MSTest
{
    [TestClass]
    public class Lesson4Project2MSTestUnitTest1
    {
        [TestMethod]
        public void TestMethodGetMaxElInTreeByDepth1()
        {
            MethodInfo mTest = typeof(TreeHelper).GetMethod("GetMaxElInTreeByDepth", BindingFlags.Static | BindingFlags.NonPublic);

            System.Console.WriteLine(mTest.Name);

            List<(int expected, int arg)> datas = new List<(int expected, int arg)>() 
            {
                (1, 0),
                (3, 1),
                (7, 2),
                (15, 3),
                (31, 4),
                (63, 5),
                (127, 6),
                (255, 7),
                (511, 8),
                (1_023, 9),
                (2_047, 10)
            };

            foreach (var data in datas)
                Assert.AreEqual(data.expected, (int)mTest.Invoke(null, new object[] { data.arg }));
        }

        [TestMethod]
        public void TestMethodGetSizeEl2()
        {
            MethodInfo mTest = typeof(TreeHelper).GetMethod("GetSizeEl", BindingFlags.Static | BindingFlags.NonPublic);

            System.Console.WriteLine(mTest.Name);

            List<(int expected, int baseSize, int basePadding, int maxDepth, int depth)> datas = new List<(int expected, int baseSize, int basePadding, int maxDepth, int depth)>()
            {
                //len2
                (2, 2, 2, 1, 0),
                (2, 2, 2, 1, 1),
                (6, 2, 2, 2, 0),
                (2, 2, 2, 2, 1),
                (2, 2, 2, 2, 2),
                (16, 2, 2, 3, 0),
                (6, 2, 2, 3, 1),
                (2, 2, 2, 3, 2),
                (2, 2, 2, 3, 3),
                (36, 2, 2, 4, 0),
                (16, 2, 2, 4, 1),
                (6, 2, 2, 4, 2),
                (2, 2, 2, 4, 3),
                (2, 2, 2, 4, 4),
                (76, 2, 2, 5, 0),
                (36, 2, 2, 5, 1),
                (16, 2, 2, 5, 2),
                (6, 2, 2, 5, 3),
                (2, 2, 2, 5, 4),
                (2, 2, 2, 5, 5),
                //len3
                (3, 3, 3, 1, 0),
                (3, 3, 3, 1, 1),
                (9, 3, 3, 2, 0),
                (3, 3, 3, 2, 1),
                (3, 3, 3, 2, 2),
                (23, 3, 3, 3, 0),
                (9, 3, 3, 3, 1),
                (3, 3, 3, 3, 2),
                (3, 3, 3, 3, 3),
                (51, 3, 3, 4, 0),
                (23, 3, 3, 4, 1),
                (9, 3, 3, 4, 2),
                (3, 3, 3, 4, 3),
                (3, 3, 3, 4, 4),
                (107, 3, 3, 5, 0),
                (51, 3, 3, 5, 1),
                (23, 3, 3, 5, 2),
                (9, 3, 3, 5, 3),
                (3, 3, 3, 5, 4),
                (3, 3, 3, 5, 5),
                //len4
                (4, 4, 2, 1, 0),
                (4, 4, 2, 1, 1),
                (10, 4, 2, 2, 0),
                (4, 4, 2, 2, 1),
                (4, 4, 2, 2, 2),
                (26, 4, 2, 3, 0),
                (10, 4, 2, 3, 1),
                (4, 4, 2, 3, 2),
                (4, 4, 2, 3, 3),
                (58, 4, 2, 4, 0),
                (26, 4, 2, 4, 1),
                (10, 4, 2, 4, 2),
                (4, 4, 2, 4, 3),
                (4, 4, 2, 4, 4),
                (122, 4, 2, 5, 0),
                (58, 4, 2, 5, 1),
                (26, 4, 2, 5, 2),
                (10, 4, 2, 5, 3),
                (4, 4, 2, 5, 4),
                (4, 4, 2, 5, 5),
                //len5
                (5, 5, 3, 1, 0),
                (5, 5, 3, 1, 1),
                (13, 5, 3, 2, 0),
                (5, 5, 3, 2, 1),
                (5, 5, 3, 2, 2),
                (33, 5, 3, 3, 0),
                (13, 5, 3, 3, 1),
                (5, 5, 3, 3, 2),
                (5, 5, 3, 3, 3),
                (73, 5, 3, 4, 0),
                (33, 5, 3, 4, 1),
                (13, 5, 3, 4, 2),
                (5, 5, 3, 4, 3),
                (5, 5, 3, 4, 4),
                (153, 5, 3, 5, 0),
                (73, 5, 3, 5, 1),
                (33, 5, 3, 5, 2),
                (13, 5, 3, 5, 3),
                (5, 5, 3, 5, 4),
                (5, 5, 3, 5, 5),
            };

            foreach (var data in datas)
                Assert.AreEqual(data.expected, (int)mTest.Invoke(null, new object[] { data.baseSize, data.basePadding, data.maxDepth, data.depth }));
        }

        [TestMethod]
        public void TestMethodGetPaddingBetweenEl3()
        {
            MethodInfo mTest = typeof(TreeHelper).GetMethod("GetPaddingBetweenEl", BindingFlags.Static | BindingFlags.NonPublic);

            System.Console.WriteLine(mTest.Name);

            List<(int expected, int baseSize, int basePadding, int maxDepth, int depth)> datas = new List<(int expected, int baseSize, int basePadding, int maxDepth, int depth)>()
            {
                //len2
                (8, 2, 2, 1, 0),
                (2, 2, 2, 1, 1),
                (14, 2, 2, 2, 0),
                (8, 2, 2, 2, 1),
                (2, 2, 2, 2, 2),
                (24, 2, 2, 3, 0),
                (14, 2, 2, 3, 1),
                (8, 2, 2, 3, 2),
                (2, 2, 2, 3, 3),
                (44, 2, 2, 4, 0),
                (24, 2, 2, 4, 1),
                (14, 2, 2, 4, 2),
                (8, 2, 2, 4, 3),
                (2, 2, 2, 4, 4),
                (84, 2, 2, 5, 0),
                (44, 2, 2, 5, 1),
                (24, 2, 2, 5, 2),
                (14, 2, 2, 5, 3),
                (8, 2, 2, 5, 4),
                (2, 2, 2, 5, 5),
                //len3
                (3, 3, 3, 1, 0),
                (3, 3, 3, 1, 1),
                (9, 3, 3, 2, 0),
                (3, 3, 3, 2, 1),
                (3, 3, 3, 2, 2),
                (23, 3, 3, 3, 0),
                (9, 3, 3, 3, 1),
                (3, 3, 3, 3, 2),
                (3, 3, 3, 3, 3),
                (51, 3, 3, 4, 0),
                (23, 3, 3, 4, 1),
                (9, 3, 3, 4, 2),
                (3, 3, 3, 4, 3),
                (3, 3, 3, 4, 4),
                (107, 3, 3, 5, 0),
                (51, 3, 3, 5, 1),
                (23, 3, 3, 5, 2),
                (9, 3, 3, 5, 3),
                (3, 3, 3, 5, 4),
                (3, 3, 3, 5, 5),
                //len4
                (4, 4, 2, 1, 0),
                (4, 4, 2, 1, 1),
                (10, 4, 2, 2, 0),
                (4, 4, 2, 2, 1),
                (4, 4, 2, 2, 2),
                (26, 4, 2, 3, 0),
                (10, 4, 2, 3, 1),
                (4, 4, 2, 3, 2),
                (4, 4, 2, 3, 3),
                (58, 4, 2, 4, 0),
                (26, 4, 2, 4, 1),
                (10, 4, 2, 4, 2),
                (4, 4, 2, 4, 3),
                (4, 4, 2, 4, 4),
                (122, 4, 2, 5, 0),
                (58, 4, 2, 5, 1),
                (26, 4, 2, 5, 2),
                (10, 4, 2, 5, 3),
                (4, 4, 2, 5, 4),
                (4, 4, 2, 5, 5),
                //len5
                (5, 5, 3, 1, 0),
                (5, 5, 3, 1, 1),
                (13, 5, 3, 2, 0),
                (5, 5, 3, 2, 1),
                (5, 5, 3, 2, 2),
                (33, 5, 3, 3, 0),
                (13, 5, 3, 3, 1),
                (5, 5, 3, 3, 2),
                (5, 5, 3, 3, 3),
                (73, 5, 3, 4, 0),
                (33, 5, 3, 4, 1),
                (13, 5, 3, 4, 2),
                (5, 5, 3, 4, 3),
                (5, 5, 3, 4, 4),
                (153, 5, 3, 5, 0),
                (73, 5, 3, 5, 1),
                (33, 5, 3, 5, 2),
                (13, 5, 3, 5, 3),
                (5, 5, 3, 5, 4),
                (5, 5, 3, 5, 5),
            };

            foreach (var data in datas)
            {
                System.Console.WriteLine($"{nameof(data.expected)}: {data.expected}, {nameof(data.baseSize)}: {data.baseSize}, {nameof(data.basePadding)}: {data.basePadding}, {nameof(data.maxDepth)}: {data.maxDepth}, {nameof(data.depth)}: {data.depth}");
                Assert.AreEqual(data.expected, (int)mTest.Invoke(null, new object[] { data.baseSize, data.basePadding, data.maxDepth, data.depth }));
            }
        }

    }
}
