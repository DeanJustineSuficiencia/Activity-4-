using System;

class CurrencyConverter
{
    static void Main()
    {
        // Conversion rate from USD to EUR
        double conversionRate = 0.85;

        // Asking user to enter an amount in USD
        Console.Write("Enter the amount in USD: ");
        double usd = Convert.ToDouble(Console.ReadLine());

        // Convert USD to EUR
        double eur = usd * conversionRate;

        // Display the result
        Console.WriteLine($"{usd} USD is equivalent to {eur} EUR.");
    }
}