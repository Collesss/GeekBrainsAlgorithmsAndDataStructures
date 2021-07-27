using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    public class Tree<T> : ITree<T>
    {
        private TreeNode<T> root;

        public int Count { get; private set; }

        public void AddItem(T value)
        {
            if (root == null)
                root = new TreeNode<T>(value);
            else
            {
                TreeNode<T> tN = root;
                int c = Count;

                while (c > 2)
                {
                    if ((c - 1) % 2 == 1)
                        tN = tN.RightChild;
                    else
                        tN = tN.LeftChild;

                    c = (c - 1) / 2;
                }

                TreeNode<T> newValue = new TreeNode<T>(value);

                if (c == 1)
                    tN.LeftChild = newValue;
                else if (c == 2)
                    tN.RightChild = newValue;
                else
                    throw new Exception("FUCK");
            }

            Count++;
        }

        public TreeNode<T> GetNodeByValue(T value)
        {
            Stack<TreeNode<T>> treeNodes = new Stack<TreeNode<T>>();
            TreeNode<T> res = new TreeNode<T>(default);
            if (root != null)
                treeNodes.Push(root);

            while (treeNodes.Count > 0)
            {
                if (treeNodes.Peek().Value.Equals(value))
                {
                    res = treeNodes.Peek();
                    break;
                }

                if (treeNodes.Peek().LeftChild != null)
                    treeNodes.Push(treeNodes.Peek().LeftChild);

                if (treeNodes.Peek().RightChild != null)
                    treeNodes.Push(treeNodes.Peek().RightChild);

                treeNodes.Pop();
            }

            return res;
        }



        public TreeNode<T> GetRoot() =>
            root;

        public string PrintTree() =>
            TreeHelper.GetStringTree(root);

        public void RemoveItem(T value)
        {
            throw new NotImplementedException();
        }
    }
}
