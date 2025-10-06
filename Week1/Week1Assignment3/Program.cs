using System;

int attempts = 0;
const int maxAttempts = 3;
bool success = false;
int number = 0;

while (attempts < maxAttempts)
{
    Console.Write("Enter an integer: ");
    string? input = Console.ReadLine()?.Trim();

    if (int.TryParse(input, out number))
    {
        success = true;
        break;
    }
    else
    {
        attempts++;
        int remaining = maxAttempts - attempts;
        Console.WriteLine(remaining > 0
            ? $"Invalid input. {remaining} attempt(s) left.\n"
            : "");
    }
}

if (success)
    Console.WriteLine($" You entered the number: {number}");
else
    Console.WriteLine(" Too many failed attempts. Please try again later.");