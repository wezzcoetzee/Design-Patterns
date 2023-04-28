namespace Bridge;

public class TextMessage : Message
{
    private readonly string _content;

    public TextMessage(IMessageSender messageSender, string content)
        : base(messageSender)
    {
        _content = content;
    }

    public override void Send()
    {
        MessageSender.SendMessage(_content);
    }
}

public class ImageMessage : Message
{
    private readonly string _imageUrl;

    public ImageMessage(IMessageSender messageSender, string imageUrl)
        : base(messageSender)
    {
        _imageUrl = imageUrl;
    }

    public override void Send()
    {
        MessageSender.SendMessage($"Image: {_imageUrl}");
    }
}

public class VideoMessage : Message
{
    private readonly string _videoUrl;

    public VideoMessage(IMessageSender messageSender, string videoUrl)
        : base(messageSender)
    {
        _videoUrl = videoUrl;
    }

    public override void Send()
    {
        MessageSender.SendMessage($"Video: {_videoUrl}");
    }
}