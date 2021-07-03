using System;

namespace Lesson2Project1
{
    class Lesson2Project1
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);
            linkedList.AddNode(6);

            Console.WriteLine(linkedList.GetCount());
            Console.WriteLine();

            foreach (int item in linkedList)
                Console.WriteLine(item);


            Node node1 = linkedList.FindNode(1);
            Node node2 = linkedList.FindNode(2);
            Node node3 = linkedList.FindNode(3);
            Node node4 = linkedList.FindNode(4);
            Node node5 = linkedList.FindNode(5);
            Node node6 = linkedList.FindNode(6);

            Console.WriteLine();
            Console.WriteLine(node1.Value);
            Console.WriteLine(node2.Value);
            Console.WriteLine(node3.Value);
            Console.WriteLine(node4.Value);
            Console.WriteLine(node5.Value);
            Console.WriteLine(node6.Value);

            Console.WriteLine();

            linkedList.AddNodeAfter(node1, 10);
            linkedList.AddNodeAfter(node2, 20);
            linkedList.AddNodeAfter(node3, 30);
            linkedList.AddNodeAfter(node4, 40);
            linkedList.AddNodeAfter(node5, 50);
            linkedList.AddNodeAfter(node6, 60);

            foreach (int item in linkedList)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine(linkedList.GetCount());
            Console.WriteLine();

            linkedList.RemoveNode(node1);
            linkedList.RemoveNode(node2);
            linkedList.RemoveNode(node3);
            linkedList.RemoveNode(node4);
            linkedList.RemoveNode(node5);
            linkedList.RemoveNode(node6);

            foreach (int item in linkedList)
                Console.WriteLine(item);

            linkedList.RemoveNode(0);
            linkedList.RemoveNode(4);

            Console.WriteLine();

            foreach (int item in linkedList)
                Console.WriteLine(item);


            Console.ReadKey();
        }
    }
}
