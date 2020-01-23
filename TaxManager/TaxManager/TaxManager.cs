using System;
using System.Collections.Generic;
using System.Text;

namespace TaxManager
{
    public abstract class TaxManager
    {
        protected double grossAmount;
        protected double incomeTax;
        protected double universalSocialCharge;
        protected double pension;
        protected double netAmount;

        public TaxManager(double hourlyRate, double hoursWorked)
        {
            grossAmount = hourlyRate * hoursWorked;
            incomeTax = CalculateIncomeTax();
            universalSocialCharge = CalculateUniversalSocialCharge();
            pension = CalculatePension();
            netAmount = CalculateTakeHomePay();
        }

        public abstract double CalculateIncomeTax();

        public abstract double CalculateUniversalSocialCharge();

        public abstract double CalculatePension();

        public abstract string GetLocation();

        public double CalculateTakeHomePay()
        {
            return grossAmount - (incomeTax + universalSocialCharge + pension);
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            sb.AppendLine(@$"Employee location: {GetLocation()}");
            sb.AppendLine(@$"Gross Amount: € {grossAmount}");
            sb.AppendLine(string.Empty);
            sb.AppendLine(@$"Less deductions");
            sb.AppendLine(string.Empty);
            sb.AppendLine(@$"Income Tax: € {incomeTax}");
            sb.AppendLine(@$"Universal Social Charge: € {universalSocialCharge}");
            sb.AppendLine(@$"Pension: € {pension}");
            sb.AppendLine(@$"Net Amount: € {netAmount}");

            return sb.ToString();
        }
    }
}