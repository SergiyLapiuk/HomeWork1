using System;

namespace Converter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the DOLLAR exchange rate:");
            double dollar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the EURO exchange rate:");
            double euro = Convert.ToDouble(Console.ReadLine());
            Converter converter = new Converter(dollar, euro);
        }
    }

    class Converter
    {
        public Converter(double usd, double eur)
        {
            Console.WriteLine("From hryvnia to foreign currency(1) or from currency in hryvnia(2)");
            if(Console.ReadLine() == "1" )
            {
                Console.WriteLine("Enter the amount in UAN:");
                double UAN = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("In usd(1) or eur(2):");
                if(Console.ReadLine() == "1")
                {
                    Console.WriteLine("UAN -> USD:");
                    Console.WriteLine(UAN / usd);
                }
                else
                {
                    Console.WriteLine("UAN -> EUR:");
                    Console.WriteLine(UAN / eur);
                }
            }
            else
            {
                Console.WriteLine("From dollars(1) or euro(2) in hryvnia:");
                if(Console.ReadLine() == "1")
                {
                    Console.WriteLine("Enter the amount in USD:");
                    double USD = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("USD -> UAN:");
                    Console.WriteLine(USD*usd);
                }
                else
                {
                    Console.WriteLine("Enter the amount in EUR:");
                    double EUR = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("EUR -> UA:");
                    Console.WriteLine(EUR * eur);
                }
            }
        }
    }
}
