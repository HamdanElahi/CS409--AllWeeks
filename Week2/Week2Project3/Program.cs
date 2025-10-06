using System;

class Program
{
    static void Main()
    {
        Console.Write("Full name: ");
        string? fullNameIn = Console.ReadLine();

        Console.Write("City: ");
        string? cityIn = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fullNameIn) || string.IsNullOrWhiteSpace(cityIn))
        {
            Console.WriteLine("Both name and city are required.");
            return;
        }

        string fullName = fullNameIn.Trim();
        string city = cityIn.Trim();

        // Split name by whitespace
        string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        char firstInitial = char.ToUpperInvariant(parts[0][0]);
        char lastInitial = (parts.Length > 1)
            ? char.ToUpperInvariant(parts[^1][0])  // last token's first char
            : '_';                                 // placeholder if no last name

        string initials = (lastInitial == '_')
            ? $"{firstInitial}."
            : $"{firstInitial}.{lastInitial}.";

        int nameLength = fullName.Length; // includes spaces

        string id = $"{city.ToUpperInvariant()}_{firstInitial}{(lastInitial == '_' ? "" : lastInitial)}_{nameLength}";

        Console.WriteLine($"Hello, {fullName} ({initials}) from {city}");
        Console.WriteLine($"Name length: {nameLength}");
        Console.WriteLine($"ID: {id}");
    }
}
