using System;

namespace TaxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlyRate = 12.1321;
            double hoursWorked = 42;

            GermanyTaxManager gtm = new GermanyTaxManager(hourlyRate, hoursWorked);
            Console.WriteLine(gtm.GetInfo());
        }
    }
}