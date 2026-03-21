
// Weather Analyzer
// This program analyzes a set of temperature values.
// It finds the maximum, minimum, average temperature,
// and counts how many days are considered hot.


int[] temps = { 22, 28, 31, 35, 27 };


Console.WriteLine("Weather Analyzer");
Console.WriteLine($"Max: {GetMax(temps)}");
Console.WriteLine($"Min: {GetMin(temps)}");
Console.WriteLine($"Average: {GetAverage(temps)}");
Console.WriteLine($"Hot Days (>30): {CountHotDays(temps)}");


static int GetMax(int[] temps)
{
    int maxTemp = temps[0];

    foreach (int t in temps)
    {
        if ( t > maxTemp)
        {
            maxTemp = t;
        }
    }

    return maxTemp;
}


static int GetMin(int[] temps)
{
    int minTemp = temps[0];

    foreach (int t in temps)
    {
        if (t < minTemp)
        {
            minTemp = t;
        }
    }

    return minTemp;
}


static double GetAverage(int[] temps)
{
    double sum = 0;

    foreach (int t in temps)
    {
        sum += t;
    }

    double avg = sum / temps.Length;

    return avg;
}


static int CountHotDays(int[] temps)
{
    int count = 0;

    foreach (int t in temps)
    {
        if (t > 30)
        {
            count++;
        }
    }

    return count;
}