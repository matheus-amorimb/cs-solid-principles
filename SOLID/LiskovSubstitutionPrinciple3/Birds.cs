namespace ConsoleApp1LiskovSubstitutionPrinciple3;

public class Birds
{
    public string? Name { get;}
    public Birds(string name)
    {
        Name = name;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"\n{Name} is eating...");
    }
    
    public virtual void LayEggs()
    {
        Console.WriteLine($"\n{Name} is laying eggs...");
    }
    
}