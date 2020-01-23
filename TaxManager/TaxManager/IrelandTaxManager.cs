using TaxManager.Strategy;

namespace TaxManager
{
    public class IrelandTaxManager : TaxManager
    {
        public IrelandTaxManager(double hourlyRate, double hoursWorked) : base(hourlyRate, hoursWorked)
        {
            SetIncomeTaxes(new IrelandIncomeTax());
            SetPension(new IrelandPension());
            SetUniversalSocialCharge(new IrelandUniversalSocialCharge());
            SetLocation(new IrelandLocation());
        }
    }
}