namespace _1SingleResponsabilityPrinciple;

public class Order
{
    public long Quantity { get; private set;}
    
    public DateTime Data { get; set; }

    public void AddOrder()
    {
        try
        {
            Quantity = 100;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteOrder()
    {
        
    }
}