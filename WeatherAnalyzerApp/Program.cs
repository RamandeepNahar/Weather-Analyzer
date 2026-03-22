
// Weather Analyzer
// This program analyzes a set of temperature values.
// It finds the maximum, minimum, average temperature,
// and counts how many days are considered hot.

using System.Runtime.Serialization.Formatters;

Console.WriteLine("Weather Analyzer");
Console.WriteLine("Enter how many days: ");
int days = int.Parse(Console.ReadLine());
Console.WriteLine("-------------");
int[] temps = new int[days];


for (int i = 0; i < temps.Length; i++)
{

    Console.Write($"Enter temperature for day {i + 1}: ");
    temps[i] = int.Parse(Console.ReadLine());

}

Console.WriteLine($"Max: {GetMax(temps)}");
Console.WriteLine($"Min: {GetMin(temps)}");
Console.WriteLine($"Average: {GetAverage(temps)}");
Console.WriteLine($"Hot Days (> 30): {CountHotDays(temps)}");
Console.WriteLine($"Cold Days (< 10): {CountColdDays(temps)}");


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


static int CountColdDays(int[] temps)
{
    int count = 0;
    
    foreach (int t in temps)
    {
        if (t < 10)
        {
            count++;
        }
    }

    return count;
}