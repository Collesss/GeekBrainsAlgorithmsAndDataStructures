using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Lesson3Project1;

namespace Lesson3Project1BenchmarkDotNet
{
    [MemoryDiagnoser]
    [RankColumn]
    class Lesson3Project1BenchmarkDistance
    {


        [Benchmark]
        public void BenchmarkPointClass()
        {

        }

        [Benchmark]
        public void BenchmarkPointStructFloat()
        {

        }

        [Benchmark]
        public void BenchmarkPointStructDouble()
        {

        }

        [Benchmark]
        public void BenchmarkPointStructFloatSqrDistance()
        {

        }
    }
}
