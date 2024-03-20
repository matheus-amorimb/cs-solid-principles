namespace _2OpenClosedPrinciple;

public class DiscountAssociatesCustomer : Order
{
    public override double OrderDiscount(double finalValue)
    {
        return finalValue - 100;
    }
}