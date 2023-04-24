namespace Proxy;

public class RealVideo : IVideo
{
    private readonly string _filename;

    public RealVideo(string filename)
    {
        _filename = filename;
        LoadVideo();
    }

    private void LoadVideo()
    {
        Console.WriteLine($"Loading video: {_filename}");
    }

    public void Play()
    {
        Console.WriteLine($"Playing video: {_filename}");
    }
}