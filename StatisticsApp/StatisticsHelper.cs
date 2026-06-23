namespace StatisticsApp;

public static class StatisticsHelper
{
    public static int Sum(int[] values)
    {
        int sum = 0;
        foreach (int value in values)
        {
            sum += value;
        }
        return sum;
    }

    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
        {
            return 0;
        }

        return (double)Sum(values) / values.Length;
    }

    public static int CalculateMax(int[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("Array must not be empty.", nameof(values));
        }

        int max = values[0];
        foreach (int value in values)
        {
            if (value > max)
            {
                max = value;
            }
        }

        return max;
    }

    public static int CalculateMin(int[] values)
    {
        if (values.Length == 0)
        {
            throw new ArgumentException("Array must not be empty.", nameof(values));
        }

        int min = values[0];
        foreach (int value in values)
        {
            if (value < min)
            {
                min = value;
            }
        }

        return min;
    }
}
