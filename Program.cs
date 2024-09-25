namespace TemperaturCelsiusTillFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //från Celsius till Fahrenheit

            Console.WriteLine("Enter the temprature in Celsius: ");

            string trmpratureInCelsiusSomString = Console.ReadLine()!;

            int tempratureInCelsius = Convert.ToInt32(trmpratureInCelsiusSomString);

            ConvertToFahtenheit myconverter = new ConvertToFahtenheit();

            int tempraturInFahrenheit = myconverter.ConvertCelsiusTillFahtenheit(tempratureInCelsius);

            Console.WriteLine($"The temperatuer in Fahrenheit is : {tempraturInFahrenheit}");



        }
    }
}
