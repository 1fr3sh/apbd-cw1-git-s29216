using StatisticsApp;

Console.WriteLine("Enter numbers separated by spaces:");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Error: no input provided.");
    return;
}

int[] numbers;
try
{
    numbers = input
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
}
catch (FormatException)
{
    Console.WriteLine("Error: please enter integer numbers only.");
    return;
}

Console.WriteLine();
Console.WriteLine("===== Statistics Report =====");
Console.WriteLine($"Sum: {StatisticsHelper.Sum(numbers)}");
Console.WriteLine($"Average: {StatisticsHelper.CalculateAverage(numbers)}");
Console.WriteLine($"Max: {StatisticsHelper.CalculateMax(numbers)}");
Console.WriteLine($"Min: {StatisticsHelper.CalculateMin(numbers)}");
