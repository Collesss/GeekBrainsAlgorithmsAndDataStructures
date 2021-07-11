using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project1BenchmarkDotNet
{
    [MemoryDiagnoser, RankColumn]
    [MaxColumn, MinColumn]
    public class Lesson4Project1BenchmarkSearch
    {
        private HashSet<string> hashSet;
        private string[] array;

        private Random random;
        private int seed;


        private const int size = 10_000;



        public Lesson4Project1BenchmarkSearch()
        {
            seed = (int)DateTime.Now.Ticks;

            hashSet = new HashSet<string>(size);
            array = new string[size];

            for (int i = 0; i < size; i++)
            {
                string str = GetStr(3, i);
                array[i] = str;
                hashSet.Add(str);
            }

        }

        [GlobalSetup]
        public void GlobalSetup() =>
            random = new Random(seed);

        private string GetStr(int len, int num)
        {
            int c = 93;
            int s = 34;

            char[] chars = new char[len];

            for (int i = 0; i < len; i++)
            {
                chars[i] = (char)(s + num % c);
                num /= c;
            }

            return new string(chars);
        }


        [Benchmark]
        public void SearchInArrayFor()
        {
            string findStr = GetStr(3, random.Next(0, size));

            for (int i = 0; i < array.Length; i++)
                if (array[i] == findStr)
                    break;
        }

        [Benchmark]
        public void SearchInArrayFindIndex()
        {
            string findStr = GetStr(3, random.Next(0, size));
            Array.FindIndex(array, str => str == findStr);
        }

        [Benchmark]
        public void SearchInArrayFind()
        {
            string findStr = GetStr(3, random.Next(0, size));
            Array.Find(array, str => str == findStr);
        }

        [Benchmark]
        public void SearchInHashSetTryGetValue()
        {
            string findStr = GetStr(3, random.Next(0, size));
            hashSet.TryGetValue(findStr, out string _);
        }

        [Benchmark]
        public void SearchInHashSetContains()
        {
            string findStr = GetStr(3, random.Next(0, size));
            hashSet.Contains(findStr);
        }
    }
}
