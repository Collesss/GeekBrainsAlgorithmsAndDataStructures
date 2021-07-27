using System;
using Lesson4Project2;
using System.Collections.Generic;
using System.Text;

namespace Lesson5Project1
{
    public static class ExtensionsTree
    {
        public static TreeNode<T> BreadthFirstSearch<T>(this Tree<T> tree, T value)
        {
            Queue<TreeNode<T>> treeNodes = new Queue<TreeNode<T>>();
            TreeNode<T> res = new TreeNode<T>(default);
            if (tree.GetRoot() != null)
                treeNodes.Enqueue(tree.GetRoot());

            while (treeNodes.Count > 0)
            {
                if (treeNodes.Peek().Value.Equals(value))
                {
                    res = treeNodes.Peek();
                    break;
                }

                if (treeNodes.Peek().LeftChild != null)
                    treeNodes.Enqueue(treeNodes.Peek().LeftChild);

                if (treeNodes.Peek().RightChild != null)
                    treeNodes.Enqueue(treeNodes.Peek().RightChild);

                treeNodes.Dequeue();
            }

            return res;
        }


        public static TreeNode<T> DeepFirstSearch<T>(this Tree<T> tree, T value)
        {
            Stack<TreeNode<T>> treeNodes = new Stack<TreeNode<T>>();
            TreeNode<T> res = new TreeNode<T>(default);
            if (tree.GetRoot() != null)
                treeNodes.Push(tree.GetRoot());

            while (treeNodes.Count > 0)
            {
                TreeNode<T> node = treeNodes.Pop();

                if (value.Equals(node.Value))
                {
                    res = node;
                    break;
                }

                if (node.LeftChild != null)
                    treeNodes.Push(node.LeftChild);

                if (node.RightChild != null)
                    treeNodes.Push(node.RightChild);

            }

            return res;
        }
    }
}
