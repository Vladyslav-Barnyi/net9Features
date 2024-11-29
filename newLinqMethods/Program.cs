var someText = """
        ¿Te gusta leer? Yo leo un libro todas las semanas. 
        Y a veces, leo dos libros. Además, soy periodista y tengo que leer mucho en el trabajo. 
        Soy especialista en noticias científicas y todos los días escribo un artículo.
        """;

//pinpoint to bug that I found :)

KeyValuePair<string, int> mostFrequentWord = someText
        .Split(new[] { ' ', '.', ',', '?', '¡', '¿' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => x.ToLowerInvariant())
        .CountBy(word => word)
        .MaxBy(x => x.Value);

Console.WriteLine($"{mostFrequentWord.Key}: {mostFrequentWord.Value}");

//2
(string id, int score)[] data =
[
        ("0", 42),
        ("1", 5),
        ("2", 4),
        ("1", 10),
        ("0", 25),
];

var result = data.AggregateBy(seed: 0,
        func: (totalScore, curr) => totalScore + curr.score,
        keySelector: entry => entry.id);
//debug

var resultOld = data
        .GroupBy(entry => entry.id) // Group by 'id'
        .Select(group => new
        {
                Id = group.Key,
                TotalScore = group.Sum(entry => entry.score) // Aggregate scores
        });

Console.WriteLine();
 //3
IEnumerable<string> lines = File.ReadAllLines("file.txt");

//old approach
// foreach ((string line, int index) in lines.Select((line, index) => (line, index)))
// {
//         Console.WriteLine($"Line number: {index + 1}, Line: {line}");
// }

foreach (var(index, line) in lines.Index())
{
        Console.WriteLine($"Line number: {index + 1}, Line: {line}");
}

Console.WriteLine();