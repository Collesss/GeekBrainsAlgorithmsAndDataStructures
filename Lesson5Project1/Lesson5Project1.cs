using System;
using System.Linq;
using System.Collections;
using Lesson4Project2;
using System.Collections.Generic;

namespace Lesson5Project1
{
    class Lesson5Project1
    {
        static void Main(string[] args)
        {
            Tree<int> tree = new Tree<int>();

            Enumerable.Range(0, 1 << 5).ToList().ForEach(i => tree.AddItem(i));

            for (int i = 0; i < 1 << 5; i++)
                Console.WriteLine(tree.BreadthFirstSearch(i).Value);

            Console.WriteLine(new string('-', 90));

            for (int i = 0; i < 1 << 5; i++)
                Console.WriteLine(tree.DeepFirstSearch(i).Value);

            Console.ReadKey();
        }
    }
}
