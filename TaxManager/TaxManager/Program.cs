using System;

namespace TaxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyRate = 12.1321;
            double hoursWorked = 42;

            TaxManager gtm = new GermanyTaxManager(hourlyRate, hoursWorked);
            Console.WriteLine(gtm.GetInfo());
            gtm = new ItalyTaxManager(hourlyRate, hoursWorked);
            Console.WriteLine(gtm.GetInfo());
            gtm = new IrelandTaxManager(hourlyRate, hoursWorked);
            Console.WriteLine(gtm.GetInfo());
        }
    }
}