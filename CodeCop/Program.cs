List<Task<int>> tasks = Enumerable.Range(1, 5).Select(Calculate).ToList();

//new
await foreach (var task in Task.WhenEach(tasks))
{
    Console.WriteLine(await task);
}

//old hack
/*while (tasks.Any())
{
    var completedTask = await Task.WhenAny(tasks);
    tasks.Remove(completedTask);
    Console.WriteLine(await completedTask);
}*/

//casual
/*var results = await Task.WhenAll(tasks);

foreach (var result in results)
{
    Console.WriteLine(result);
}*/

async Task<int> Calculate(int order)
{
    var number = Random.Shared.Next(500, 5000);
    await Task.Delay(number);
    return order;
}