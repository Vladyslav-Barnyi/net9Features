// See https://aka.ms/new-console-template for more information

using System.Buffers;
using BenchmarkDotNet.Running;
using SearchValuesUpdate;

Console.WriteLine("Hello, World!");

SearchValues<string> searchValues = SearchValues.Create(
    ["Vlad", "Fer", "Alex", "Ali"], StringComparison.OrdinalIgnoreCase);
    
Console.WriteLine(searchValues.Contains("vlad"));

Console.WriteLine(MemoryExtensions.ContainsAny("fer", searchValues));

//BenchmarkRunner.Run<Benchmarks>();
BenchmarkRunner.Run<OldBenchmark>();