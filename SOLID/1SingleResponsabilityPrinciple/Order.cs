namespace _1SingleResponsabilityPrinciple;

public class Order
{
    public long Quantity { get; private set;}
    public DateTime Data { get; set; }
    private ILogger? _logger;
    private SendEmail _sendEmail;
    public Order()
    {
        _sendEmail = new SendEmail();
        _logger = new Logger();
    }
    
    public void AddOrder()
    {
        try
        {
            _logger.Info("Including order");
            _sendEmail.EmailFrom = "mabatista1@gmail.com";
            _sendEmail.EmailTo = "mabatista2@gmail.com";
            _sendEmail.EmailSubject = "Single Responsability Principle";
            // _sendEmail.EmailBody = "Learning the first principle of SOLID Principles";
            _sendEmail.Send();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void DeleteOrder()
    {
        
    }
}