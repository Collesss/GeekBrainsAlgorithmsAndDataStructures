using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    class Tree<T> : ITree<T>
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
                newValue.Parent = tN;

                if (c == 1)
                    tN.LeftChild = newValue;
                else if (c == 2)
                    tN.RightChild = newValue;
                else
                    throw new Exception("Alg error");
            }

            Count++;
        }

        public TreeNode<T> GetNodeByValue(T value)
        {
            Queue<TreeNode<T>> treeNodes = new Queue<TreeNode<T>>();
            TreeNode<T> res = new TreeNode<T>(default);
            if (root != null)
                treeNodes.Enqueue(root);

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

        public bool GetNodeByValue(T value, out TreeNode<T> result)
        {
            Queue<TreeNode<T>> treeNodes = new Queue<TreeNode<T>>();
            result = new TreeNode<T>(default);
            if (root != null)
                treeNodes.Enqueue(root);

            while (treeNodes.Count > 0)
            {
                if (treeNodes.Peek().Value.Equals(value))
                {
                    result = treeNodes.Peek();
                    return true;
                }

                if (treeNodes.Peek().LeftChild != null)
                    treeNodes.Enqueue(treeNodes.Peek().LeftChild);

                if (treeNodes.Peek().RightChild != null)
                    treeNodes.Enqueue(treeNodes.Peek().RightChild);

                treeNodes.Dequeue();
            }

            return false;
        }

        public TreeNode<T> GetRoot() =>
            root;

        public string PrintTree() =>
            TreeHelper.GetStringTree(root);

        public void RemoveItem(T value)
        {
            /*
            bool ReplaceInParent(TreeNode<T> node, TreeNode<T> nodeReplace = null)
            {
                if (node.Parent != null)
                {
                    TreeNode<T> nodeParent = node.Parent;

                    if (nodeParent.LeftChild == node)
                        nodeParent.LeftChild = nodeReplace;
                    else if (nodeParent.RightChild == node)
                        nodeParent.RightChild = nodeReplace;

                    return true;
                }

                return false;
            }
            */

            if (GetNodeByValue(value, out TreeNode<T> removeEl))
            {
                TreeNode<T> lastAddEl = LastAddEl();

                if (lastAddEl != removeEl)
                {
                    TreeNode<T> addLastAddElParent = lastAddEl.Parent;

                    if (addLastAddElParent.LeftChild == lastAddEl)
                        addLastAddElParent.LeftChild = null;
                    else if (addLastAddElParent.RightChild == lastAddEl)
                        addLastAddElParent.RightChild = null;

                    lastAddEl.Parent = removeEl.Parent;
                    lastAddEl.LeftChild = removeEl.LeftChild;
                    lastAddEl.RightChild = removeEl.RightChild;

                    TreeNode<T> removeElParent = removeEl.Parent;

                    if (removeElParent == null)
                        root = lastAddEl;
                    else
                    {
                        if (removeElParent.LeftChild == removeEl)
                            removeElParent.LeftChild = lastAddEl;
                        else if (removeElParent.RightChild == removeEl)
                            removeElParent.RightChild = lastAddEl;
                    }
                }
                else
                {
                    TreeNode<T> removeElParent = removeEl.Parent;

                    if (removeElParent != null)
                    {
                        if (removeElParent.LeftChild == removeEl)
                            removeElParent.LeftChild = null;
                        else if (removeElParent.RightChild == removeEl)
                            removeElParent.RightChild = null;
                    }
                }

                if (removeEl.LeftChild != null)
                    removeEl.LeftChild.Parent = lastAddEl;

                if (removeEl.RightChild != null)
                    removeEl.RightChild.Parent = lastAddEl;

                removeEl.Parent = removeEl.LeftChild = removeEl.RightChild = null;

                Count--;
            }
        }

        private TreeNode<T> LastAddEl()
        {
            TreeNode<T> tN = root;
            int c = Count - 1;

            while (c > 2)
            {
                if ((c - 1) % 2 == 1)
                    tN = tN.RightChild;
                else
                    tN = tN.LeftChild;

                c = (c - 1) / 2;
            }

            return c switch
            {
                0 => root,
                1 => tN.LeftChild,
                2 => tN.RightChild,
                _ => throw new Exception("Alg error")
            };
        }
    }
}
