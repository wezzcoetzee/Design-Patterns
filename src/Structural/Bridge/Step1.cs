namespace Bridge;

public abstract class Message
{
    protected readonly IMessageSender MessageSender;

    protected Message(IMessageSender messageSender)
    {
        MessageSender = messageSender;
    }

    public abstract void Send();
}