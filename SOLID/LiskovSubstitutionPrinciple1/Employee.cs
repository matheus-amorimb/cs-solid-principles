namespace LiskovSubstitutionPrinciple1;

public class Employee
{
    private string? Name { get; set; }
    private string? Role { get; set; }

    public Employee(string name, string role)
    {
        Name = name;
        Role = role;
    }

    public virtual double CalculateWage(double wage)
    {
        return wage;
    }
    
}