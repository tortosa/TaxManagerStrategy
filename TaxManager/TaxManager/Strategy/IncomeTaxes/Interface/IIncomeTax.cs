namespace TaxManager.Strategy
{
    public interface IIncomeTax
    {
        public double Calculate(double grossAmount);
    }
}