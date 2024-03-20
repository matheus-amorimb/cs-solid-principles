namespace _1SingleResponsabilityPrinciple;

public class SendEmail
{
    public string EmailFrom { get; set; }
    public string EmailTo { get; set; }
    public string EmailSubject { get; set; }
    public string EmailBody { get; set; }

    public void Send()
    {
        Console.WriteLine($"From: {EmailFrom}");
        Console.WriteLine($"To: {EmailTo}");
        Console.WriteLine($"Subject: {EmailSubject}");
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"{EmailBody}");
    }
    
}