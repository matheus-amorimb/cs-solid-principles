namespace LiskovSubstitutionPrinciple1;

public class Seller : Employee
{
    private double bonus = 1500;
    public Seller(string name, string role) : base(name, role) {}

    public override double CalculateWage(double wage)
    {
        return wage + bonus;
    }
}
