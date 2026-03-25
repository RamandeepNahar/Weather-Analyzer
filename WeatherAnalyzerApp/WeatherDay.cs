

// WeatherDay Class - this the blueprint for a weather day object
using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

class WeatherDay
{

    // Member variable - private field that stores the temperature
    // Private means only code inside this class can access it directly.
    private int temperature;


    // Property Temperature - controls access to the private temperature field
    public int Temperature 
    { 
        get { return temperature; } // returns the temperature field
        set { temperature = value; } // assigns the temperature field to the given value
    }



    // Constructor - runs automatically when a new WeatherDay object is created
    // Takes a temp parameter and assigns it to the temperature field
    public WeatherDay(int temp)
    {
        temperature = temp;
    }
}


