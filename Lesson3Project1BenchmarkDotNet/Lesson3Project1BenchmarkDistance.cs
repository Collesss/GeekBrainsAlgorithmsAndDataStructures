using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Lesson3Project1;

namespace Lesson3Project1BenchmarkDotNet
{
    /*
    [MemoryDiagnoser, RankColumn]
    [SimpleJob(RuntimeMoniker.NetCoreApp31), SimpleJob(RuntimeMoniker.Net50)]
    [MaxColumn, MinColumn]
    public class Lesson3Project1BenchmarkDistance
    {
        private Random random;

        private int seed;

        private PointClass pc1;
        private PointClass pc2;

        private PointStructFloat psf1;
        private PointStructFloat psf2;

        private PointStructDouble psd1;
        private PointStructDouble psd2;

        public Lesson3Project1BenchmarkDistance()
        {
            seed = (int)DateTime.Now.Ticks;
        }

        [GlobalSetup]
        public void GlobalSetup()
        {
            random = new Random(seed);
        }

        [IterationSetup(Target = nameof(BenchmarkPointClass))]
        public void IterationSetupPointClass()
        {
            pc1 = new PointClass()
            {
                x = random.Next(-10000, 10000) * 0.02f,
                y = random.Next(-10000, 10000) * 0.02f
            };

            pc2 = new PointClass()
            {
                x = random.Next(-10000, 10000) * 0.02f,
                y = random.Next(-10000, 10000) * 0.02f
            };
        }

        [IterationSetup(Targets = new string[]{ nameof(BenchmarkPointStructFloat), nameof(BenchmarkPointStructFloatSqrDistance) })]
        public void IterationSetupPointFloat()
        {
            psf1 = new PointStructFloat()
            {
                x = random.Next(-10000, 10000) * 0.02f,
                y = random.Next(-10000, 10000) * 0.02f
            };

            psf2 = new PointStructFloat()
            {
                x = random.Next(-10000, 10000) * 0.02f,
                y = random.Next(-10000, 10000) * 0.02f
            };
        }

        [IterationSetup(Target = nameof(BenchmarkPointStructDouble))]
        public void IterationSetupPointStructDouble()
        {
            psd1 = new PointStructDouble()
            {
                x = random.NextDouble() * 200 - 100,
                y = random.NextDouble() * 200 - 100
            };

            psd2 = new PointStructDouble()
            {
                x = random.NextDouble() * 200 - 100,
                y = random.NextDouble() * 200 - 100
            };
        }

        [Benchmark]
        public void BenchmarkPointClass()
        {
            Point.Distance(pc1, pc2);
        }

        [Benchmark]
        public void BenchmarkPointStructFloat()
        {
            Point.Distance(psf1, psf2);
        }

        [Benchmark]
        public void BenchmarkPointStructDouble()
        {
            Point.Distance(psd1, psd2);
        }

        [Benchmark]
        public void BenchmarkPointStructFloatSqrDistance()
        {
            Point.SqrDistance(psf1, psf2);
        }
    }
    */
    
    [MemoryDiagnoser, RankColumn]
    [SimpleJob(RuntimeMoniker.NetCoreApp31), SimpleJob(RuntimeMoniker.Net50)]
    //[LegacyJitX64Job, LegacyJitX86Job, RyuJitX64Job, RyuJitX86Job]
    [MaxColumn, MinColumn]
    public class Lesson3Project1BenchmarkDistance
    {
        private Random random;

        private int seed;

        public Lesson3Project1BenchmarkDistance()
        {
            seed = (int)DateTime.Now.Ticks;
        }

        [GlobalSetup]
        public void GlobalSetup()
        {
            random = new Random(seed);
        }

        [Benchmark]
        public void BenchmarkPointClass()
        {
            Point.Distance(new PointClass()
                {
                    x = random.Next(-10000, 10000) * 0.02f,
                    y = random.Next(-10000, 10000) * 0.02f
                },
                new PointClass()
                {
                    x = random.Next(-10000, 10000) * 0.02f,
                    y = random.Next(-10000, 10000) * 0.02f
                });
        }

        [Benchmark]
        public void BenchmarkPointStructFloat()
        {
            Point.Distance(new PointStructFloat()
                {
                   x = random.Next(-10000, 10000) * 0.02f,
                    y = random.Next(-10000, 10000) * 0.02f
                },
                new PointStructFloat()
                {
                    x = random.Next(-10000, 10000) * 0.02f,
                    y = random.Next(-10000, 10000) * 0.02f
                });
        }

        [Benchmark]
        public void BenchmarkPointStructDouble()
        {
            Point.Distance(new PointStructDouble()
                {
                    x = random.NextDouble() * 200 - 100,
                    y = random.NextDouble() * 200 - 100
                },
                new PointStructDouble()
                {
                    x = random.NextDouble() * 200 - 100,
                    y = random.NextDouble() * 200 - 100
                });
        }

        [Benchmark]
        public void BenchmarkPointStructFloatSqrDistance()
        {
            Point.SqrDistance(new PointStructFloat()
                {
                    x = random.Next(-10000, 10000) * 0.02f,
                    y = random.Next(-10000, 10000) * 0.02f
                },
                new PointStructFloat()
                {
                    x = random.Next(-10000, 10000) * 0.02f,
                    y = random.Next(-10000, 10000) * 0.02f
                });
        }
    }
}
