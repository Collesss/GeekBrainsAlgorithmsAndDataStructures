|                               Method |           Job |       Runtime |      Mean |    Error |   StdDev |       Max |       Min | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------- |-------------- |-------------- |----------:|---------:|---------:|----------:|----------:|-----:|-------:|------:|------:|----------:|
|                  BenchmarkPointClass |      .NET 5.0 |      .NET 5.0 |  78.81 ns | 0.491 ns | 0.435 ns |  79.84 ns |  78.31 ns |    1 | 0.0114 |     - |     - |      48 B |
|            BenchmarkPointStructFloat |      .NET 5.0 |      .NET 5.0 |  84.40 ns | 0.658 ns | 0.583 ns |  85.17 ns |  83.57 ns |    2 |      - |     - |     - |         - |
|           BenchmarkPointStructDouble |      .NET 5.0 |      .NET 5.0 | 101.85 ns | 0.234 ns | 0.195 ns | 102.37 ns | 101.61 ns |    3 |      - |     - |     - |         - |
| BenchmarkPointStructFloatSqrDistance |      .NET 5.0 |      .NET 5.0 |  84.44 ns | 1.685 ns | 1.873 ns |  87.06 ns |  79.77 ns |    2 |      - |     - |     - |         - |
|                  BenchmarkPointClass | .NET Core 3.1 | .NET Core 3.1 |  83.00 ns | 1.561 ns | 1.460 ns |  85.44 ns |  79.61 ns |    2 | 0.0114 |     - |     - |      48 B |
|            BenchmarkPointStructFloat | .NET Core 3.1 | .NET Core 3.1 |  85.65 ns | 1.142 ns | 1.012 ns |  87.40 ns |  84.33 ns |    2 |      - |     - |     - |         - |
|           BenchmarkPointStructDouble | .NET Core 3.1 | .NET Core 3.1 | 110.48 ns | 2.024 ns | 1.893 ns | 113.76 ns | 106.65 ns |    4 |      - |     - |     - |         - |
| BenchmarkPointStructFloatSqrDistance | .NET Core 3.1 | .NET Core 3.1 |  84.23 ns | 1.670 ns | 2.172 ns |  89.79 ns |  81.54 ns |    2 |      - |     - |     - |         - |