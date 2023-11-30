using Lab6;

internal class Program
{
    private static void Main(string[] args)
    {
        EuroCurrencyConverter eu1 = new EuroCurrencyConverter("Mono", 40);
        Console.WriteLine(eu1);
        Console.WriteLine(eu1.ConvertToUSD(200));
    }
}