using BenchmarkDotNet.Running;
using System;

namespace Lesson3Project1BenchmarkDotNet
{
    class Lesson3Project1BenchmarkDotNet
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Lesson3Project1BenchmarkDistance>();
        }
    }
}
