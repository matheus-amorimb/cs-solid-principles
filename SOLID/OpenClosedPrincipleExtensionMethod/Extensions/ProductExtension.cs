namespace _2OpenClosePrinciple.Extensions;

public static class ProductExtension
{
    public static double ProfitMargin(this Product product)
    {
        try
        {
            var netProfit = product.Sale - product.Cost;
            var profitMargin = (netProfit / product.Sale) * 100;
            return Convert.ToDouble(profitMargin);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}