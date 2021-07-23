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
        public void TestMethod1()
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
    }
}
