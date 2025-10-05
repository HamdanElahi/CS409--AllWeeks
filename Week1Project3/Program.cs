using System;

// Week 1 – Assignment 3: Unit Converter Pro
// Target Framework: .NET 8
// Goal: Menu-driven console app with at least 4 conversions; remembers last choice.

string? lastChoice = null;

while (true)
{
    Console.WriteLine("=== UNIT CONVERTER PRO ===");
    Console.WriteLine("1. Kilometers → Miles");
    Console.WriteLine("2. Miles → Kilometers");
    Console.WriteLine("3. Kilograms → Pounds");
    Console.WriteLine("4. Pounds → Kilograms");
    Console.WriteLine("5. Celsius → Fahrenheit");
    Console.WriteLine("6. Fahrenheit → Celsius");
    Console.WriteLine("7. Meters → Feet");
    Console.WriteLine("8. Feet → Meters");
    Console.WriteLine("0. Exit");

    if (!string.IsNullOrEmpty(lastChoice))
        Console.Write($"Select an option [Enter = {lastChoice}]: ");
    else
        Console.Write("Select an option: ");

    string? choice = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(choice) && !string.IsNullOrEmpty(lastChoice))
        choice = lastChoice;

    if (choice == "0")
    {
        Console.WriteLine("Goodbye! ");
        break;
    }

    if (!int.TryParse(choice, out int option) || option < 1 || option > 8)
    {
        Console.WriteLine("Invalid choice. Try again.");
        continue;
    }

    Console.Write("Enter value to convert: ");
    string? valueText = Console.ReadLine()?.Trim();

    if (!double.TryParse(valueText, out double value))
    {
        Console.WriteLine("Invalid numeric input.");
        continue;
    }

    double result = 0;
    string from = "", to = "";

    switch (option)
    {
        case 1: result = value * 0.621371; from = "km"; to = "mi"; break;
        case 2: result = value / 0.621371; from = "mi"; to = "km"; break;
        case 3: result = value * 2.20462; from = "kg"; to = "lb"; break;
        case 4: result = value / 2.20462; from = "lb"; to = "kg"; break;
        case 5: result = (value * 9 / 5) + 32; from = "°C"; to = "°F"; break;
        case 6: result = (value - 32) * 5 / 9; from = "°F"; to = "°C"; break;
        case 7: result = value * 3.28084; from = "m"; to = "ft"; break;
        case 8: result = value / 3.28084; from = "ft"; to = "m"; break;
    }

    Console.WriteLine($"{value} {from} = {result:F2} {to}");
    lastChoice = choice;
}