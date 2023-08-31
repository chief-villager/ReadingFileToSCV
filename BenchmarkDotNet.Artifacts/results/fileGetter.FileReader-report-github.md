```

BenchmarkDotNet v0.13.7, macOS Monterey 12.6.8 (21G725) [Darwin 21.6.0]
Intel Core i5-5257U CPU 2.70GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET SDK 7.0.302
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|  Method |     Mean |   Error |  StdDev | Allocated |
|-------- |---------:|--------:|--------:|----------:|
| GetData | 290.2 ms | 5.78 ms | 5.94 ms | 196.22 KB |
