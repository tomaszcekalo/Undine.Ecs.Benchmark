// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Undine.Benchmark;
using Undine.Benchmark.Components;
using Undine.Benchmark.Systems;
using Undine.Core;
using static Leopotam.EcsLite.EcsWorld;

var config = ManualConfig.CreateEmpty()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator);
config.Add(DefaultConfig.Instance.GetExporters().ToArray());
config.Add(DefaultConfig.Instance.GetLoggers().ToArray());
config.Add(DefaultConfig.Instance.GetColumnProviders().ToArray());
var results = BenchmarkRunner.Run<EcsBenchmark>(config);