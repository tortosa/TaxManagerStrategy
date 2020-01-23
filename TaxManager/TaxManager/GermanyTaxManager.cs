using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManager
{
    public class GermanyTaxManager : TaxManager
    {
        public GermanyTaxManager(double hourlyRate, double hoursWorked) : base(hourlyRate, hoursWorked)
        { }

        public override double CalculateIncomeTax()
        {
            const int AMOUNT_LIMIT = 400;
            var firstAmount = grossAmount;
            double remaining = 0;
            if (grossAmount > AMOUNT_LIMIT)
            {
                firstAmount = AMOUNT_LIMIT;
                remaining = grossAmount - AMOUNT_LIMIT;
            }

            return firstAmount * 0.25 + remaining * 0.32;
        }

        public override double CalculatePension()
        {
            return grossAmount * 0.02;
        }

        public override double CalculateUniversalSocialCharge()
        {
            return 0;
        }

        public override string GetLocation()
        {
            return "Germany";
        }
    }
}