//first

using System.IO.Pipes;

var example = new Example
{
    array =
    {
        [0]= 1,
        [^4] = 10,
        [^3] = 20,
        [^2] = 30,
        [^1] = 40
    }
};
foreach (var value in example.array)
{
    Console.WriteLine(value);
}
//2

Guid.CreateVersion7();

//third

var person = new Person();
person.GetAge();



// not available now why??
//public implicit extension 
//public explicit extension 

public static class PersonExtension
{
    public static int GetAge(this Person person)
    {
        return DateTime.Today.Year - person.DateOfBirth.Year;
    }
}

//4
// in c 13 we will have ability to pass not only arrays to params but also lists ienum span and custom stuff 
// int SumNumbers(params List<int> numbers)
// {
//     return numbers.Sum();
// }


//classes
public class Person
{
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class Example
{
    public int[] array = new int[5];
}