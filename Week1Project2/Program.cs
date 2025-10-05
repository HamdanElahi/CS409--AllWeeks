using System;

Console.Write("How many temperature readings (N > 0)? ");
string? nText = Console.ReadLine()?.Trim();

if (!int.TryParse(nText, out int N) || N <= 0)
{
    Console.WriteLine("Invalid number of readings. Exiting...");
    return;
}

int[] temps = new int[N];

for (int i = 0; i < N; i++)
{
    while (true)
    {
        Console.Write($"Enter temperature #{i + 1}: ");
        string? tText = Console.ReadLine()?.Trim();

        if (int.TryParse(tText, out int value))
        {
            temps[i] = value;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer temperature.");
        }
    }
}

// Initialize stats
int min = temps[0];
int max = temps[0];
int sum = 0;

// Compute min, max, and sum
foreach (int t in temps)
{
    if (t < min) min = t;
    if (t > max) max = t;
    sum += t;
}

double avg = sum / (double)N;

// Print results
Console.WriteLine("--- Temperature Stats ---");
Console.WriteLine($"Count: {N}");
Console.WriteLine($"Min:   {min}");
Console.WriteLine($"Max:   {max}");
Console.WriteLine($"Avg:   {avg:F2}°C");

// Simple histogram
Console.WriteLine("--- Histogram ---");
foreach (int t in temps)
{
    Console.WriteLine($"{t,4}°C | {new string('*', Math.Abs(t / 2))}");
}