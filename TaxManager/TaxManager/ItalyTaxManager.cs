using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManager
{
    public class ItalyTaxManager : TaxManager
    {
        public ItalyTaxManager(double hourlyRate, double hoursWorked) : base(hourlyRate, hoursWorked)
        { }

        public override double CalculateIncomeTax()
        {
            return grossAmount * 0.25;
        }

        public override double CalculatePension()
        {
            return 0;
        }

        public override double CalculateUniversalSocialCharge()
        {
            return grossAmount * 0.919;
        }

        public override string GetLocation()
        {
            return "Italy";
        }
    }
}