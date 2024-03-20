namespace _2OpenClosedPrinciple;

public class Order
{
    public virtual double OrderDiscount(double finalValue)
    {
        return finalValue;
    }
}