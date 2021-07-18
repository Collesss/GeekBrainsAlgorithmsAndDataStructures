using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    class Tree<T> : ITree<T>
    {
        private TreeNode<T> root;

        private TreeNode<T> leftAdd;
        private TreeNode<T> rightAdd;

        private bool addRight = false;

        public void AddItem(T value)
        {
            if (root == null)
                root = new TreeNode<T>(value);
            else
            {
                if (!addRight)
                {

                }
                else
                {
                    
                }
            }
        }

        public TreeNode<T> GetNodeByValue(T value)
        {
            throw new NotImplementedException();
        }

        public TreeNode<T> GetRoot()
        {
            throw new NotImplementedException();
        }

        public void PrintTree()
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(T value)
        {
            throw new NotImplementedException();
        }
    }
}
