namespace _2OpenClosePrinciple;

public class Product
{
    public Product(int id, string name, string description, 
        decimal cost, decimal sale, int stock, bool active)
    {
        ProductId = id;
        Name = name;
        Description = description;
        Cost = cost;
        Sale = sale;
        Stock = stock;
        Active = active;
    }
    public int ProductId { get; private set; }
    public string? Name { get; private set; }
    public string? Description { get; private set; }
    private decimal _cost { get; set;}
    public decimal Cost
    {
        // get => _cost;
        get { return _cost; }
        private set
        {
            if (value > 0)
            {
                _cost = value;
            }
        }

    }
    private decimal _sale { get; set;}
    public decimal Sale
    {
        // get => _cost;
        get { return _sale;}
        private set
        {
            if (value > 0)
            {
                _sale = value;
            }
        }
    }
    public int Stock { get; private set; }
    public bool Active { get; private set; }
    
    
    
}