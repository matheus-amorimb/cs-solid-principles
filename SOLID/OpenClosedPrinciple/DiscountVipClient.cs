namespace _2OpenClosedPrinciple;

public class DiscountVipClient: Order
{
    public override double OrderDiscount(double finalValue)
    {
        return finalValue - 200;
    }
}