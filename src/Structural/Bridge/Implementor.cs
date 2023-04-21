namespace Bridge;

public interface IMessageSender
{
    void SendMessage(string content);
}

public class EmailSender : IMessageSender
{
    public void SendMessage(string content)
    {
        Console.WriteLine($"Email message sent: {content}");
    }
}

public class SmsSender : IMessageSender
{
    public void SendMessage(string content)
    {
        Console.WriteLine($"SMS message sent: {content}");
    }
}

public class PushNotificationSender : IMessageSender
{
    public void SendMessage(string content)
    {
        Console.WriteLine($"Push notification sent: {content}");
    }
}