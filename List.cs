List<string> names = ["<name>", "Ana", "Felipe"]; // list has string type elements innit
foreach (var name in names) // for name in names : similar work 
{
    Console.WriteLine($"{name.ToUpper()}!");
}

Console.WriteLine();
names.Add("Maria");  // same as append in python adds to the end of the list.
names.Add("Bill");
names.Remove("Ana"); // searches and removes similar to .remove
foreach (var name in names)
{
    Console.WriteLine($"{name.ToUpper()}!");
}

Console.WriteLine($"{names[0]}.");
Console.WriteLine($"added {names[2]} {names[3]} ");

Console.WriteLine($"My name is {names[0]}."); // index calls 
Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");


Console.WriteLine($"The list has {names.Count} people in it");  // similar to len() in python 

var index = names.IndexOf("Felipe"); // indexof similar to index[] of python 
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if (index == -1) // means false not found 
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}


names.Sort(); // sorting simple 
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


List<int> fibonacciNumbers = [1, 1];
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}