using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    public class TreeNode<T>
    {
        public TreeNode<T> Parent { get; set; }
        public T Value { get; set; }
        public TreeNode<T> LeftChild { get; set; }
        public TreeNode<T> RightChild { get; set; }

        public TreeNode() { }
        public TreeNode(T Value) =>
            this.Value = Value;

        public TreeNode(T Value, TreeNode<T> Parent) : this(Value) =>
            this.Parent = Parent;

        public TreeNode(T Value, TreeNode<T> Parent, bool LeftNode) : this(Value)
        {
            this.Parent = Parent;

            if (Parent != null)
                if (LeftNode)
                    Parent.LeftChild = this;
                else
                    Parent.RightChild = this;
        }
        public void Replace(TreeNode<T> whatOnReplace)
        {
            if (this != whatOnReplace)
            {
                if (Parent != null)
                {
                    if (Parent.LeftChild == this)
                        Parent.LeftChild = whatOnReplace;
                    else if (Parent.RightChild == this)
                        Parent.RightChild = whatOnReplace;
                }

                if (LeftChild != null)
                    LeftChild.Parent = whatOnReplace;

                if (RightChild != null)
                    RightChild.Parent = whatOnReplace;

                if (whatOnReplace != null)
                {
                    whatOnReplace.Parent = Parent;
                    whatOnReplace.LeftChild = LeftChild;
                    whatOnReplace.RightChild = RightChild;
                }
            }
        }

        public override int GetHashCode() =>
            Value?.GetHashCode() ?? 0;
        public override bool Equals(object obj) => 
            obj is TreeNode<T> node && (Value?.Equals(node.Value) ?? false);
    }
}
