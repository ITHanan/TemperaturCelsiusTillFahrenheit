

namespace TemperaturCelsiusTillFahrenheit
{
    public class ConvertToFahtenheit
    {
        public int ConvertCelsiusTillFahtenheit(int tempratureInCelsius) 
        { 
            int tempraturInFahrenheit = (tempratureInCelsius * 9 / 5) + 32;

            return tempraturInFahrenheit;



        }
    }
}
