using System;
using System.Collections.Generic;
using System.Text;
using Lesson4Project2;

namespace Lesson8Project1
{
    public class JustBinarySearchTree<T> : ITree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;
        public int Count { get; private set; }


        public JustBinarySearchTree(){}

        public JustBinarySearchTree(IEnumerable<T> array) 
        {
            foreach (T value in array)
                AddItem(value);
        }


        public void AddItem(T value)
        {
            if (root == null)
                root = new TreeNode<T>(value);
            else
            {
                TreeNode<T> curEl = root;

                while (true)
                {
                    if (curEl.Value.CompareTo(value) >= 0)
                    {
                        if (curEl.RightChild != null)
                            curEl = curEl.RightChild;
                        else
                        {
                            new TreeNode<T>(value, curEl, false);
                            break;
                        }
                    }
                    else
                    {
                        if (curEl.LeftChild != null)
                            curEl = curEl.LeftChild;
                        else
                        {
                            new TreeNode<T>(value, curEl, true);
                            break;
                        }
                    }
                }
            }

            Count++;
        }

        public TreeNode<T> GetNodeByValue(T value)
        {
            TreeNode<T> res = new TreeNode<T>(default);
            TreeNode<T> curEl = root;

            while (true)
            {
                if (curEl == null)
                    break;

                int comp = curEl.Value.CompareTo(value);

                if (comp > 0)
                    curEl = curEl.RightChild;
                else if (comp < 0)
                    curEl = curEl.LeftChild;
                else
                {
                    res = curEl;
                    break;
                }
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
