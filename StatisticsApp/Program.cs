using StatisticsApp;

Console.WriteLine("Enter numbers separated by spaces:");
string? input = Console.ReadLine();

int[] numbers = input!
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Console.WriteLine($"Sum: {StatisticsHelper.Sum(numbers)}");
