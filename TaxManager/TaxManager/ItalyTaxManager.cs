using TaxManager.Strategy;

namespace TaxManager
{
    public class ItalyTaxManager : TaxManager
    {
        public ItalyTaxManager(double hourlyRate, double hoursWorked) : base(hourlyRate, hoursWorked)
        {
            SetIncomeTaxes(new ItalyIncomeTax());
            SetPension(new ItalyPension());
            SetUniversalSocialCharge(new ItalyUniversalSocialCharge());
            SetLocation(new ItalyLocation());
        }
    }
}