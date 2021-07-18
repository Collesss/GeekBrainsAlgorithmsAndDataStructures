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
           depth == 0 ? 0 : 1 << depth;

        private static int GetPaddingBetweenEl(int baseSize, int basePadding, int maxDepth, int depth) =>
            (baseSize * 2 + basePadding) * (int)Math.Pow(2, maxDepth - depth) - (baseSize * 2);

        private static int GetSizeEl(int baseSize, int basePadding, int maxDepth, int depth)
        {
            if (depth >= maxDepth - 1)
                return baseSize;

            if (depth == maxDepth - 2)
                return baseSize * 2 + basePadding;

            int countElInDownLine = GetMaxElInTreeInDownByDepth(maxDepth - depth) / 2;
            int longPadding = baseSize + 2;
            int countLongPad = countElInDownLine / 2;
            int countShortPad = countLongPad - 1;

            return countElInDownLine * baseSize + countLongPad * longPadding + countShortPad * basePadding - (baseSize - baseSize % 2);
        }

        public static string GetStringTree<T>(TreeNode<T> root)
        {
            (int maxLenData, int maxDepth) = GetMaxLenDataAndDepth(root);
            int basePadding = 2 + maxLenData % 2;

            Stack<(int dataLen, int leftPadding)> lens = new Stack<(int dataLen, int leftPadding)>(maxLenData + 1);
            lens.Push((maxLenData, 0));
            lens.Push((maxLenData, maxLenData + 1));
            if(maxDepth >= 2)
                lens.Push((lens.Peek().dataLen * 2 + basePadding, maxLenData * 2 + 2));

            for (int i = 2; i < maxDepth; i++)
            {
                lens.Push(((lens.Peek().dataLen + 1) * 2 + maxLenData, lens.Peek().leftPadding + ((lens.Peek().dataLen - maxLenData) / 2) + 1 + maxLenData));
            }

            Queue<TreeNode<T>> nodes = new Queue<TreeNode<T>>();
            nodes.Enqueue(root);

            for (int i = 0; i < maxDepth; i++)
            {
                TreeNode<T>[] t = new TreeNode<T>[1 << i];

                for (int j = 0; j < 1 << i; i++)
                {
                    nodes.Enqueue(nodes.Peek()?.LeftChild);
                    nodes.Enqueue(nodes.Peek()?.RightChild);

                    t[j] = nodes.Dequeue();
                }
            }
            
            return null;
        }
    }
}
