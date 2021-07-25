using System;

namespace Lesson4Project2
{
    class Lesson4Project2
    {
        static void Main(string[] args)
        {
            /*
            TreeNode<int> root = new TreeNode<int>(1000);
            root.LeftChild = new TreeNode<int>(20);
            root.RightChild = new TreeNode<int>(30);
            root.LeftChild.LeftChild = new TreeNode<int>(40);
            root.LeftChild.RightChild = new TreeNode<int>(50);
            root.RightChild.LeftChild = new TreeNode<int>(60);
            root.RightChild.RightChild = new TreeNode<int>(70);
            root.LeftChild.LeftChild.LeftChild = new TreeNode<int>(80);
            root.LeftChild.LeftChild.LeftChild.RightChild = new TreeNode<int>(90);
            */
            //(int maxLenData, int maxDepth) = TreeHelper.GetMaxLenDataAndDepth(root);

            //Console.WriteLine(TreeHelper.GetStringTree(root));

            Tree<int> tree = new Tree<int>();

            for (int i = 0; i < (1 << 6) - 1; i++)
            {
                tree.AddItem(i);
                Console.WriteLine(tree.PrintTree());
            }


            //Console.WriteLine($"maxLenData: {maxLenData}; maxDepth: {maxDepth};");
            Console.ReadKey();
        }
    }
}
