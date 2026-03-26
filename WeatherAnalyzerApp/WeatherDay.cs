

// WeatherDay Class - this the blueprint for a weather day object
class WeatherDay
{

    // Private field - stores the temperature in Celsius
    // Only accessible inside this class directly
    private int temperature;


    // Property Temperature - controls access to the private temperature field
    public int Temperature 
    { 
        get 
        { 
            // Returns the Celsius temperature
            return temperature;
        }

        set 
        { 
            // Validates the value before assigning - rejects unrealistic temperatures
            if (value < -90 || value > 60)
            {
                Console.WriteLine("Not Possible temperatures!");
            }
            else
            {
                // Assigns the valid value to the private temperature field
                temperature = value; 
            }

        } 
    }

    // Property Fahrenheit - converts and returns temperature in Fahrenheit
    // No set needed - calculated from temperature field
    public int Fahrenheit
    {
        get
        {
            int F = (temperature * 9 / 5) + 32;
            return F;
        }

    }


    // Constructor - runs automatically when a new WeatherDay object is created
    // Goes through Temperature property to trigger validation on set
    public WeatherDay(int temp)
    {
       Temperature = temp;
    }
}


