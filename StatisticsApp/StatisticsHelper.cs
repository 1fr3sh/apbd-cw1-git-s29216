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
}
