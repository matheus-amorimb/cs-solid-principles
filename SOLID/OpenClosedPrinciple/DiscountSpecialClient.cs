namespace _2OpenClosedPrinciple;

public class DiscountSpecialClient : Order
{
    public override double OrderDiscount(double finalValue)
    {
        return finalValue - 150;
    }
}