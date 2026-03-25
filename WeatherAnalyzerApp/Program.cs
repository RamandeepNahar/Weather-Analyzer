
// Weather Analyzer
// This program analyzes a set of temperature values.
// It finds the maximum, minimum, average temperature,
// and counts how many days are considered hot.




// Creating a new WeatherDay object called day1
// Passing in 25 which goes into the constructor as temp
// Then gets stored in the temperature field
WeatherDay day1 = new WeatherDay(25);

// Accessing day1 object through the property Temperature
Console.WriteLine(day1.Temperature);


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

for (int i = 0; i < temps.Length; i++)
{
    double f = ConvertToFahrenheit(temps[i]);
    Console.WriteLine($"Day {i + 1}: {f} degrees F");
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


static double ConvertToFahrenheit(int temp)
{
    double fahrenheit = (temp * 9.0 / 5) + 32;
    return (int)fahrenheit;
}



