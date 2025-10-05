using System;

Console.Write("Enter your first name: ");
string? first = Console.ReadLine()?.Trim();

if (string.IsNullOrWhiteSpace(first))
{
    Console.WriteLine("First name cannot be empty.");
    return;
}

Console.Write("Enter your last name: ");
string? last = Console.ReadLine()?.Trim();

if (string.IsNullOrWhiteSpace(last))
{
    Console.WriteLine("Last name cannot be empty.");
    return;
}

// Make initials in uppercase
char firstInitial = char.ToUpperInvariant(first[0]);
char lastInitial = char.ToUpperInvariant(last[0]);

// Print the polite greeting
Console.WriteLine($"Hello, {first} {last} ({firstInitial}.{lastInitial}.)");