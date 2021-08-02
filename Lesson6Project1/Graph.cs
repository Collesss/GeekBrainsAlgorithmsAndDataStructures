using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson6Project1
{
    public static class Graph
    {
        private class LinkedNode
        {
            public int Count { get; private set; } = 1;
            public int Value { get; set; }
            public LinkedNode LastNode { get; private set; }

            public LinkedNode(){ }

            public LinkedNode(int Value) =>
                this.Value = Value;

            public LinkedNode(int Value, LinkedNode LastNode) : this(Value)
            {
                this.LastNode = LastNode;
                Count = LastNode.Count + 1;
            }

            public bool Contains(int Value) =>
                this.Value == Value ? true : (LastNode?.Contains(Value) ?? false);

            public static int[] GetArray(LinkedNode linkedNode)
            {
                int[] result = new int[linkedNode?.Count ?? 0];

                LinkedNode node;
                int i;
                
                for (node = linkedNode, i = 1; node != null; node = node.LastNode, i++)
                    result[^i] = node.Value;

                return result;
            }
        }

        public static int[] FindShortWayGraph(int[,] matrixWeights, int start, int end)
        {
            (LinkedNode way, int len) resultWay = (null, int.MaxValue);

            Queue<(LinkedNode way, int len)> waves = new Queue<(LinkedNode way, int len)>();

            waves.Enqueue((new LinkedNode(start), 0));

            while (waves.Count > 0)
            {
                (LinkedNode way, int len) vertex = waves.Dequeue();

                if (vertex.way.Value == end)
                {
                    if (vertex.len < resultWay.len)
                        resultWay = vertex;

                    continue;
                }

                for (int i = 0; i < matrixWeights.GetLength(0); i++)
                    if (!vertex.way.Contains(i) && matrixWeights[vertex.way.Value, i] != int.MaxValue)
                        waves.Enqueue((new LinkedNode(i, vertex.way), vertex.len + matrixWeights[vertex.way.Value, i]));
            }

            return LinkedNode.GetArray(resultWay.way);

            //return result.OrderBy(a => a.len).Select(el => el.way).FirstOrDefault() ?? new int[0];
        }

    }
} 