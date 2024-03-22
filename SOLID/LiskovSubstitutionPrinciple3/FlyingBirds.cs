namespace ConsoleApp1LiskovSubstitutionPrinciple3;

public class FlyingBirds : Birds
{
      public FlyingBirds(string name) : base(name)
      {
      }
      public virtual void Fly()
      {
            Console.WriteLine($"\nBird {Name} is flying");
      }
      
}