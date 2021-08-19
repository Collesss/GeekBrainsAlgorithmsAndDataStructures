using System;
using System.Collections.Generic;
using System.Text;
using Lesson4Project2;

namespace Lesson8Project1
{
    public static class TreeExtension
    {
        public static T[] GetArray<T>(this JustBinarySearchTree<T> tree) where T : IComparable<T>
        {
            T[] array = new T[tree.Count];

            int i = 0;

            FillArray(tree.GetRoot(), ref array, ref i);

            return array;
        }


        private static void FillArray<T>(TreeNode<T> node, ref T[] array, ref int index)
        {
            if (node != null)
            {
                FillArray(node.LeftChild, ref array, ref index);
                array[index++] = node.Value;
                FillArray(node.RightChild, ref array, ref index);
            }
        }
    }
}
