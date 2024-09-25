namespace TemperaturCelsiusTillFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //från Celsius till Fahrenheit

            UsreInteraction usre1 = new UsreInteraction();


            int tempratureInCelsius = usre1.UserInputAndConvertTONumder();

            ConvertToFahtenheit myconverter = new ConvertToFahtenheit();

            int tempraturInFahrenheit = myconverter.ConvertCelsiusTillFahtenheit(tempratureInCelsius);

            Console.WriteLine($"The temperatuer in Fahrenheit is : {tempraturInFahrenheit}");



            int tempratureInCelsius2 = usre1.UserInputAndConvertTONumder();

            int tempraturInFahrenheit2 = myconverter.ConvertCelsiusTillFahtenheit(tempratureInCelsius2);

            Console.WriteLine($"The temperatuer in Fahrenheit is : {tempraturInFahrenheit2}");






        }
    }
}
