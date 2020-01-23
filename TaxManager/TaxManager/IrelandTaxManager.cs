using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManager
{
    public class IrelandTaxManager : TaxManager
    {
        public IrelandTaxManager(double hourlyRate, double hoursWorked) : base(hourlyRate, hoursWorked)
        { }

        public override double CalculateIncomeTax()
        {
            const int AMOUNT_LIMIT = 600;
            var firstAmount = grossAmount;
            double remaining = 0;
            if (grossAmount > AMOUNT_LIMIT)
            {
                firstAmount = AMOUNT_LIMIT;
                remaining = grossAmount - AMOUNT_LIMIT;
            }

            return firstAmount * 0.25 + remaining * 0.4;
        }

        public override double CalculatePension()
        {
            return grossAmount * 0.04;
        }

        public override double CalculateUniversalSocialCharge()
        {
            const int AMOUNT_LIMIT = 500;
            var firstAmount = grossAmount;
            double remaining = 0;
            if (grossAmount > AMOUNT_LIMIT)
            {
                firstAmount = AMOUNT_LIMIT;
                remaining = grossAmount - AMOUNT_LIMIT;
            }

            return firstAmount * 0.07 + remaining * 0.08;
        }

        public override string GetLocation()
        {
            return "Ireland";
        }
    }
}