using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> LeftChild { get; set; }
        public TreeNode<T> RightChild { get; set; }

        public TreeNode() { }
        public TreeNode(T Value) => 
            this.Value = Value;

        public override bool Equals(object obj) => 
            obj is TreeNode<T> node && (Value?.Equals(node.Value) ?? false);
    }
}
