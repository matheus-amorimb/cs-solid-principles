using LiskovSubstitutionPrinciple1;

Employee employee1 = new Manager("João", "TI Manager");
Employee employee2 = new Seller("Gilson", "Digital Seller");

Console.WriteLine($"employee1 type: {employee1.GetType()}");
Console.WriteLine($"employee2 type: {employee2.GetType()}");

var wage1 = employee1.CalculateWage(5000);
var wage2 = employee2.CalculateWage(3000);

Console.WriteLine($"employee1 wage: {wage1}");
Console.WriteLine($"employee2 wage: {wage2}");
