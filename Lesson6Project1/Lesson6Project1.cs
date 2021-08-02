using System;
using System.Linq;

namespace Lesson6Project1
{
    class Lesson6Project1
    {
        static void Main(string[] args)
        {

            //A, B, C, D

            int n = int.MaxValue;

            int[,] matrixWeights = new int[,]
                {
                        //   A    B    C    D    E    F    G    H
                    /*A*/{   n,   2,   n,  10,   n,   n,   n,   n },
                    /*B*/{   2,   n,  70,   3,   n,   n,   n,   n },
                    /*C*/{   n,  70,   n,   n,   2,   n,   n,   1 },
                    /*D*/{  10,   3,   n,   n, 100,   n,   4,   1 },
                    /*E*/{   n,   n,   2, 100,   n,   3,   n,   n },
                    /*F*/{   n,   n,   n,   n,   3,   n,   1,   n },
                    /*G*/{   n,   n,   n,   4,   n,   1,   n,   n },
                    /*H*/{   n,   n,   1,   1,   n,   n,   n,   n }
                };


            string[] graph = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };

            Console.WriteLine(string.Join("->", Graph.FindShortWayGraph(matrixWeights, 3, 2).Select(d => graph[d])));
            Console.ReadKey();
        }
    }
}
