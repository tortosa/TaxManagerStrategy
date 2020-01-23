namespace TaxManager.Strategy
{
    public class IrelandUniversalSocialCharge : IUniversalSocialCharge
    {
        public double Calculate(double grossAmount)
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
    }
}