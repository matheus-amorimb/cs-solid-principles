namespace LiskovSubstitutionPrinciple1;

public class Manager : Employee
{
    private double bonus = 3000;
    
    public Manager(string name, string role) : base(name, role)
    { }

    public override double CalculateWage(double wage)
    {
        return wage + bonus;
    }
} 