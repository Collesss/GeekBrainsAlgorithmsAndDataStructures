using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson6Project1
{
    public static class Graph
    {
        public static int[] FindShortWayGraph(int[,] matrixWeights, int start, int end)
        {
            List<(int[] way, int len)> result = new List<(int[] way, int len)>();

            Queue<(int vertex, int[] way, int len)> waves = new Queue<(int vertex, int[] way, int len)>();

            
            int maxLenWay = 0;

            for (int i = 0; i < matrixWeights.GetLength(0); i++)
                for (int j = 0; j < matrixWeights.GetLength(0); j++)
                    if (matrixWeights[i, j] != int.MaxValue)
                        maxLenWay++;

            maxLenWay--;

            waves.Enqueue((start, new int[] { start }, 0));

            while (waves.Count > 0)
            {
                (int vertex, int[] way, int len) vertex = waves.Dequeue();

                if (vertex.way[vertex.way.Length - 1] == end)
                {
                    result.Add((vertex.way, vertex.len));
                    continue;
                }

                if (vertex.way.Length == maxLenWay)
                    continue;

                for (int i = 0; i < matrixWeights.GetLength(0); i++)
                {
                    if (vertex.vertex != i && !vertex.way.Contains(i) && matrixWeights[vertex.vertex, i] != int.MaxValue)
                    {
                        int[] newWay = new int[vertex.way.Length + 1];
                        vertex.way.CopyTo(newWay, 0);
                        newWay[newWay.Length - 1] = i;

                        waves.Enqueue((i, newWay, vertex.len + matrixWeights[vertex.vertex, i]));
                    }
                }
            }

            return result.OrderBy(a => a.len).Select(el => el.way).FirstOrDefault() ?? new int[0];
        }

    }
} 