namespace ConsoleApp1LiskovSubstitutionPrinciple3;

public class Penguin : Birds
{
    public Penguin(string name) : base(name)
    {
    }
    
    public override void Eat()
    { 
        Console.WriteLine($"\n{Name} eats fish...");
    }

    public override void LayEggs()
    {
        Console.WriteLine($"\n{Name} lays 2 eggs ...");
    }
}