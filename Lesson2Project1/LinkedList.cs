using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2Project1
{
    class LinkedList : ILinkedList
    {
        private Node head;
        private Node tail;

        public LinkedList(){ }

        public void AddNode(int value)
        {
            if (tail == null)
            {
                head = new Node() { Value = value };
                tail = head;
            }
            else
            {
                tail.NextNode = new Node() { Value = value };
                tail.NextNode.PrevNode = tail;
                tail = tail.NextNode;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            if (node == tail)
            {
                tail.NextNode = new Node() { Value = value };
                tail.NextNode.PrevNode = tail;
                tail = tail.NextNode;
            }
            else
            {
                node.NextNode.PrevNode = new Node() { Value = value };
                node.NextNode = node.NextNode.PrevNode;
            }
        }

        public Node FindNode(int searchValue)
        {
            Node fn = head;
            Node ln = tail;

            if (fn == null)
                return null;

            do
            {

            }
            while (fn != ln);

            return null;
        }

        public int GetCount()
        {

        }

        public void RemoveNode(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveNode(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
