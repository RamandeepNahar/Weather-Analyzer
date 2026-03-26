
// Weather Analyzer
// This program analyzes a set of temperature values.
// It finds the maximum, minimum, average temperature,
// and counts how many days are considered hot.


// Ask user for temperature input
Console.WriteLine("Enter Temperature: ");
int tempValue = int.Parse(Console.ReadLine());

// Validate input - keep asking until a realistic temperature is entered
while(tempValue < -90 || tempValue > 60)
{
    Console.WriteLine("Enter a valid temperature: ");
    tempValue = int.Parse(Console.ReadLine());

}

// Creating a new WeatherDay object using the validated temperature value
// Passes tempValue into the constructor which sets it through the Temperature property
WeatherDay day1 = new WeatherDay(tempValue);


// Accessing day1 object through the Temperature and Fahrenheit properties
Console.WriteLine($"It is feels like {day1.Temperature} degrees celsius.");
Console.WriteLine($"The temperature in fahrenheit is {day1.Fahrenheit}.");








// Console.WriteLine("Weather Analyzer");
// Console.WriteLine("Enter how many days: ");
// int days = int.Parse(Console.ReadLine());
// Console.WriteLine("-------------");
// int[] temps = new int[days];


// for (int i = 0; i < temps.Length; i++)
// {
//     Console.Write($"Enter temperature for day {i + 1}: ");
//     temps[i] = int.Parse(Console.ReadLine());
// }

// for (int i = 0; i < temps.Length; i++)
// {
//     double f = ConvertToFahrenheit(temps[i]);
//     Console.WriteLine($"Day {i + 1}: {f} degrees F");
// }

// Console.WriteLine($"Max: {GetMax(temps)}");
// Console.WriteLine($"Min: {GetMin(temps)}");
// Console.WriteLine($"Average: {GetAverage(temps)}");
// Console.WriteLine($"Hot Days (> 30): {CountHotDays(temps)}");
// Console.WriteLine($"Cold Days (< 10): {CountColdDays(temps)}");


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



