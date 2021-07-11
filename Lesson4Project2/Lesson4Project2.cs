using System;

namespace Lesson4Project2
{
    class Lesson4Project2
    {
        static void Main(string[] args)
        {
            TreeNode<int> root = new TreeNode<int>(1);
            root.LeftChild = new TreeNode<int>(2);
            root.RightChild = new TreeNode<int>(3);
            //root.LeftChild.LeftChild = new TreeNode<int>(4);
            //root.LeftChild.RightChild = new TreeNode<int>(5);
            //root.RightChild.LeftChild = new TreeNode<int>(6);
            //root.RightChild.RightChild = new TreeNode<int>(7);
            (int maxLenData, int maxDepth) = TreeHelper.GetMaxLenDataAndDepth(root);

            Console.WriteLine($"maxLenData: {maxLenData}; maxDepth: {maxDepth};");
            Console.ReadKey();
        }
    }
}
