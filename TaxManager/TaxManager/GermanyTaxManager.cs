using TaxManager.Strategy;

namespace TaxManager
{
    public class GermanyTaxManager : TaxManager
    {
        public GermanyTaxManager(double hourlyRate, double hoursWorked) : base(hourlyRate, hoursWorked)
        {
            SetIncomeTaxes(new GermanyIncomeTax());
            SetPension(new GermanyPension());
            SetUniversalSocialCharge(new GermanyUniversalSocialCharge());
            SetLocation(new GermanyLocation());
        }
    }
}