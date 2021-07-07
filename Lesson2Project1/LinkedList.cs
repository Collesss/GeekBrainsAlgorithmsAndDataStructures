using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lesson2Project1
{
    class LinkedList : ILinkedList, IEnumerable<int>
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
            Node addNode = new Node() { Value = value };

            if (node == tail)
            {
                tail.NextNode = addNode;
                addNode.PrevNode = tail;
                tail = addNode;
            }
            else
            {
                addNode.PrevNode = node;
                addNode.NextNode = node.NextNode;

                node.NextNode.PrevNode = addNode;
                node.NextNode = addNode;
            }
        }

        public Node FindNode(int searchValue)
        {
            Node fn = head;
            Node ln = tail;

            if (fn == null)
                return null;

            while (true)
            {
                if (fn.Value == searchValue)
                    return fn;
                else if (ln.Value == searchValue)
                    return ln;

                if (fn == ln || fn == ln.NextNode)
                    break;

                fn = fn.NextNode;
                ln = ln.PrevNode;
            }

            return null;
        }

        public int GetCount()
        {
            Node n = head;
            int i = 0;

            for (; n != null; i++, n = n.NextNode) ;

            return i;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (Node n = head; n != null; n = n.NextNode)
                yield return n.Value;
        }

        public void RemoveNode(int index)
        {
            Node n = head;

            for (int i = 0; n != null; i++, n = n.NextNode)
                if (i == index)
                {
                    RemoveNode(n);
                    break;
                }
        }

        public void RemoveNode(Node node)
        {
            if (node.PrevNode != null)
            {
                node.PrevNode.NextNode = node.NextNode;
            }
            else
            {
                head = node.NextNode;
                head.PrevNode = null;
            }

            if (node.NextNode != null)
                node.NextNode.PrevNode = node.PrevNode;
            else
            {
                tail = node.PrevNode;
                tail.NextNode = null;
            }

            node.PrevNode = node.NextNode = null;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
