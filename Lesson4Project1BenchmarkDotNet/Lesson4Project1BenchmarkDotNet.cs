using BenchmarkDotNet.Running;
using System;
using System.Linq;

namespace Lesson4Project1BenchmarkDotNet
{
    class Lesson4Project1BenchmarkDotNet
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Lesson4Project1BenchmarkSearch>();
        }
    }
}
