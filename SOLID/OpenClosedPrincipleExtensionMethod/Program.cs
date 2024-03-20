using _2OpenClosePrinciple;
using _2OpenClosePrinciple.Extensions;

Product product = new Product(1, "Notebook", 
    "MackBook Pro", 999, 1999, 
    100, true);

Console.WriteLine($"Product: {product.Description}");
Console.WriteLine($"Profit: ${Math.Round(product.ProfitMargin(), 2)}");