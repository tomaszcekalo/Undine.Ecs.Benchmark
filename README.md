# Undine.Benchmark

Benchmark for various ECS systems with consistent API

Results:

| Method          | Mean       | Error     | StdDev    | Median     | Gen0     | Allocated |
|---------------- |-----------:|----------:|----------:|-----------:|---------:|----------:|
| LeopotamEcs     |   6.019 ms | 0.1012 ms | 0.0845 ms |   6.026 ms |        - |       4 B |
| MgeEcs          |  18.725 ms | 0.3703 ms | 0.9425 ms |  18.289 ms |  31.2500 |  196622 B |
| MinEcs          |  11.752 ms | 0.2340 ms | 0.5282 ms |  11.740 ms |        - |       7 B |
| EntitasEcs      |  25.095 ms | 0.4958 ms | 0.5902 ms |  25.163 ms | 250.0000 | 1572887 B |
| LazyEcs         |   8.883 ms | 0.1446 ms | 0.1207 ms |   8.909 ms |        - |       7 B |
| DefaultEcs      |   8.946 ms | 0.6366 ms | 1.8059 ms |   8.626 ms |        - |       7 B |
| Simplecs        |  66.449 ms | 1.3112 ms | 2.6784 ms |  66.184 ms |        - |  311352 B |
| Audrey          | 220.293 ms | 4.3557 ms | 7.8541 ms | 219.752 ms |        - |   82069 B |
| LeopotamEcsLite |  59.601 ms | 1.1898 ms | 1.9549 ms |  59.231 ms |        - |      45 B |