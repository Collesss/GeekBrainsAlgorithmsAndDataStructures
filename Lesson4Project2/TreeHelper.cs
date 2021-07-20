using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    public static class TreeHelper
    {
        public static (int maxLenData, int maxDepth) GetMaxLenDataAndDepth<T>(TreeNode<T> node, int depth = 0)
        {
            if (node != null)
            {
                int lenData = node.Value.ToString().Length;

                (int maxLenData, int maxDepth) leftNode = GetMaxLenDataAndDepth(node.LeftChild, depth + 1);
                (int maxLenData, int maxDepth) rightNode = GetMaxLenDataAndDepth(node.RightChild, depth + 1);

                return (Max(lenData, leftNode.maxLenData, rightNode.maxLenData), Max(depth, leftNode.maxDepth, rightNode.maxDepth));
            }

            return (0, 0);
        }

        private static int Max(params int[] values)
        {
            int max = values.Length == 0 ? 0 : values[0];

            for (int i = 1; i < values.Length; i++)
                max = Math.Max(max, values[i]);

            return max;
        }

        private static int GetMaxElInTreeByDepth(int depth) =>
            (int)(uint.MaxValue >> (31 - depth));

        private static int GetMaxElInTreeInDownByDepth(int depth) =>
            1 << depth;


        private static int GetSizeEl(int baseSize, int basePadding, int maxDepth, int depth)
        {


            return 0;
        }
    }
}
