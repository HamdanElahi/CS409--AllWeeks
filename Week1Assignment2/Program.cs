using System;

int count = 0;
int sum = 0;
int min = 0;
int max = 0;

while (true)
{
    Console.Write("Enter a number (blank to finish): ");
    string? input = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(input))
        break;

    if (int.TryParse(input, out int number))
    {
        if (count == 0)
        {
            // first valid number → seed min and max
            min = max = number;
        }
        else
        {
            if (number < min) min = number;
            if (number > max) max = number;
        }

        sum += number;
        count++;
    }
    else
    {
        Console.WriteLine("❌ Invalid input. Please enter a whole number.");
    }
}

if (count > 0)
{
    double avg = sum / (double)count;
    Console.WriteLine($"\nCount: {count}");
    Console.WriteLine($"Min:   {min}");
    Console.WriteLine($"Max:   {max}");
    Console.WriteLine($"Avg:   {avg:F2}");
}
else
{
    Console.WriteLine("\nNo valid numbers were entered.");
}