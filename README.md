``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.804 (20H2/October2020Update)
Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host]     : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT
  DefaultJob : .NET Core 3.1.16 (CoreCLR 4.700.21.26205, CoreFX 4.700.21.26205), X64 RyuJIT


```
|                     Method |         Mean |      Error |       StdDev |          Max |          Min | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------- |-------------:|-----------:|-------------:|-------------:|-------------:|-----:|-------:|------:|------:|----------:|
|           SearchInArrayFor | 22,642.80 ns | 429.108 ns |   421.442 ns | 23,779.05 ns | 22,021.30 ns |    2 |      - |     - |     - |      64 B |
|     SearchInArrayFindIndex | 27,672.59 ns | 611.130 ns | 1,782.694 ns | 32,168.51 ns | 24,866.62 ns |    4 | 0.0305 |     - |     - |     152 B |
|          SearchInArrayFind | 26,017.45 ns | 121.931 ns |   114.054 ns | 26,210.83 ns | 25,834.71 ns |    3 | 0.0305 |     - |     - |     152 B |
| SearchInHashSetTryGetValue |     86.32 ns |   1.747 ns |     1.549 ns |     89.18 ns |     83.65 ns |    1 | 0.0153 |     - |     - |      64 B |
|    SearchInHashSetContains |     86.86 ns |   1.656 ns |     1.772 ns |     90.21 ns |     84.26 ns |    1 | 0.0153 |     - |     - |      64 B |
