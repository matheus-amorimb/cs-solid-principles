namespace _1SingleResponsabilityPrinciple;

public class Logger : ILogger
{
    public void Info(string info)
    {
        Console.WriteLine("\n######################");
        Console.WriteLine(info);
        Console.WriteLine("######################\n");
    }
}