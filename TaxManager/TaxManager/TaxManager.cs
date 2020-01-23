using System;
using System.Collections.Generic;
using System.Text;
using TaxManager.Strategy;

namespace TaxManager
{
    public abstract class TaxManager
    {
        private IIncomeTax incomeTax;
        private IPension pension;
        private IUniversalSocialCharge universalSocialCharge;
        private ILocation location;

        private readonly double grossAmount;
        private double incomeTaxValue;
        private double pensionValue;
        private double universalSocialChargeValue;
        private string locationValue;

        public TaxManager(double hourlyRate, double hoursWorked)
        {
            grossAmount = hourlyRate * hoursWorked;
        }

        protected void SetIncomeTaxes(IIncomeTax incomeTax)
        {
            this.incomeTax = incomeTax;
            incomeTaxValue = incomeTax.Calculate(grossAmount);
        }
        protected void SetPension(IPension pension)
        {
            this.pension = pension;
            pensionValue = pension.Calculate(grossAmount);
        }
        protected void SetUniversalSocialCharge(IUniversalSocialCharge universalSocialCharge)
        {
            this.universalSocialCharge = universalSocialCharge;
            universalSocialChargeValue = universalSocialCharge.Calculate(grossAmount);
        }
        protected void SetLocation(ILocation location)
        {
            this.location = location;
            locationValue = location.Get();
        }

        public double GetNetAmount()
        {
            return grossAmount - (incomeTaxValue + universalSocialChargeValue + pensionValue);
        }
        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            sb.AppendLine(@$"Employee location: {locationValue}");
            sb.AppendLine(@$"Gross Amount: € {grossAmount}");
            sb.AppendLine(string.Empty);
            sb.AppendLine(@$"Less deductions");
            sb.AppendLine(string.Empty);
            sb.AppendLine(@$"Income Tax: € {incomeTaxValue}");
            sb.AppendLine(@$"Universal Social Charge: € {universalSocialChargeValue}");
            sb.AppendLine(@$"Pension: € {pension.Calculate(grossAmount)}");
            sb.AppendLine(@$"Net Amount: € {GetNetAmount()}");

            return sb.ToString();
        }
    }
}