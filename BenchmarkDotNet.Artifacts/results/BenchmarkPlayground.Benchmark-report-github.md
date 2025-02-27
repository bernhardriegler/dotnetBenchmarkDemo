```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4890/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-1260P, 1 CPU, 16 logical and 12 physical cores
.NET SDK 8.0.406
  [Host]     : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2


```
| Method                  | Mean     | Error     | StdDev    |
|------------------------ |---------:|----------:|----------:|
| UsingOptionalChaining   | 7.319 ns | 0.2633 ns | 0.7554 ns |
| CheckingItemNotNullOnce | 9.257 ns | 0.4038 ns | 1.1650 ns |
