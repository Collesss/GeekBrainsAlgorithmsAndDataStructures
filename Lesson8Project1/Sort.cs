using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8Project1
{
    static class Sort
    {
        public static T[] MySort<T>(IEnumerable<T> array) where T : IComparable<T> =>
            new JustBinarySearchTree<T>(array).GetArray();
    }
}
