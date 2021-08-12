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
    
        public static string BreadthFirst(int[,] matrix, int start)
        {
            HashSet<int> beforeWave = new HashSet<int>();
            Queue<int> currentWave = new Queue<int>();
            beforeWave.Add(start);
            currentWave.Enqueue(start);

            while (currentWave.Count > 0)
                for (int i = 0, currentVertex = currentWave.Dequeue(); i < matrix.GetLength(0); i++)
                    if (matrix[currentVertex, i] != int.MaxValue && beforeWave.Add(i))
                        currentWave.Enqueue(i);

            return new string(beforeWave.Select(el => (char)(65 + el)).ToArray());
        }

        public static string DeepFirst(int[,] matrix, int start)
        {
            HashSet<int> beforeWave = new HashSet<int>();
            Stack<int> currentWave = new Stack<int>();
            beforeWave.Add(start);
            currentWave.Push(start);
            List<int> result = new List<int>();

            while (currentWave.Count > 0)
            {
                result.Add(currentWave.Peek());
                for (int i = 0, currentVertex = currentWave.Pop(); i < matrix.GetLength(0); i++)
                    if (matrix[currentVertex, i] != int.MaxValue && beforeWave.Add(i))
                        currentWave.Push(i);
            }

            return new string(result.Select(el => (char)(65 + el)).ToArray());
        }

        public static string DeepFirstV2(int[,] matrix, int start)
        {
            HashSet<int> beforeWave = new HashSet<int>();
            Stack<int> currentWave = new Stack<int>();
            beforeWave.Add(start);
            currentWave.Push(start);

            while (currentWave.Count > 0)
                for (int i = 0, currentVertex = currentWave.Pop(); i < matrix.GetLength(0); i++)
                    if (matrix[currentVertex, i] != int.MaxValue && beforeWave.Add(i))
                    {
                        currentWave.Push(currentVertex);
                        currentWave.Push(i);
                        break;
                    }

            return new string(beforeWave.Select(el => (char)(65 + el)).ToArray());
        }
    }
} 