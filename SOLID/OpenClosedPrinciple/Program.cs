using _2OpenClosedPrinciple;

double produtPrice = 1000;

DiscountAssociatesCustomer discountAssociatesCustomer = new DiscountAssociatesCustomer();
DiscountSpecialClient discountSpecialClient = new DiscountSpecialClient();
DiscountVipClient discountVipClient = new DiscountVipClient();

Console.WriteLine($"{nameof(discountAssociatesCustomer)}: ${discountAssociatesCustomer.OrderDiscount(produtPrice)}");
Console.WriteLine($"{nameof(discountSpecialClient)}: ${discountSpecialClient.OrderDiscount(produtPrice)}");
Console.WriteLine($"{nameof(discountVipClient)}: ${discountVipClient.OrderDiscount(produtPrice)}");