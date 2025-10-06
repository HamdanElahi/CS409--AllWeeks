using System;

Console.Write("Enter your name: ");
string? name = Console.ReadLine()?.Trim();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Invalid name. Exiting...");
    return;
}

Console.Write("Enter your age: ");
string? ageText = Console.ReadLine()?.Trim();

if (!int.TryParse(ageText, out int age) || age <= 0 || age > 120)
{
    Console.WriteLine("Invalid age. Exiting...");
    return;
}

Console.Write("Enter your city: ");
string? city = Console.ReadLine()?.Trim();

if (string.IsNullOrWhiteSpace(city))
{
    Console.WriteLine("Invalid city. Exiting...");
    return;
}

// Optional: initials (stretch idea)
string initials = char.ToUpperInvariant(name[0]) + ".";

// Output section
Console.WriteLine("\n--- Profile Summary ---");
Console.WriteLine($"Name: {name} ({initials})");
Console.WriteLine($"Age:  {age}");
Console.WriteLine($"City: {city}");

// Optional greeting
Console.WriteLine($"\nHello, {name} from {city}! Nice to meet you.");