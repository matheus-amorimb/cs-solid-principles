namespace ConsoleApp1LiskovSubstitutionPrinciple3;

public class Duck : FlyingBirds
{
    public Duck(string name) : base(name) {}

    public override void Eat()
    {
        Console.WriteLine($"\n{Name} eats corn...");
    }

    public override void LayEggs()
    {
        Console.WriteLine($"\n{Name} lays 6 eggs...");
    }

    public override void Fly()
    {
        Console.WriteLine($"\n{Name} flys low...");
    }
}