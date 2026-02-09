using System;
using System.Runtime.ConstrainedExecution;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double usd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EUR: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        double eur = usd * rate;

        Console.WriteLine("Amoune in EUR: " + eur.ToString("F2"));
        Console.ReadLine();

    }

}