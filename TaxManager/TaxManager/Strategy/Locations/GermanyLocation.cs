namespace TaxManager.Strategy
{
    public class GermanyLocation : ILocation
    {
        public string Get()
        {
            return "Germany";
        }
    }
}