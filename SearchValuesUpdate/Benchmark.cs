using System.Buffers;
using BenchmarkDotNet.Attributes;

namespace SearchValuesUpdate;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private static readonly string[] WordsArray =
    {
        "longing", "rusted", "furnace", "daybreak", "seventeen", "benign", "nine", "homecoming", "one", "freight car"
    };

    private static readonly SearchValues<string> SearchWords = SearchValues.Create(
        WordsArray,
        StringComparison.OrdinalIgnoreCase
    );

    [Params("furnace", "sEvEnTeEn", "pewpew")]
    public string SearchText { get; set; }

    [Benchmark]
    public bool Array_Contains()
    {
        return WordsArray.Contains(SearchText, StringComparer.OrdinalIgnoreCase);
    }

    [Benchmark]
    public bool SearchValues_Contains()
    {
        return SearchWords.Contains(SearchText);
    }
}