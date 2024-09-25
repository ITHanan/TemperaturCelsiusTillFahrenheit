

namespace TemperaturCelsiusTillFahrenheit
{
    public class UsreInteraction
    {
        public int UserInputAndConvertTONumder() 
        
        {
            Console.WriteLine("Enter the temprature in Celsius: ");

            string trmpratureInCelsiusSomString = Console.ReadLine()!;

            int tempratureInCelsius = Convert.ToInt32(trmpratureInCelsiusSomString);

            return tempratureInCelsius;


        }


    }
}
