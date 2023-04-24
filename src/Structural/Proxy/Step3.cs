namespace Proxy;

public class ProxyVideo : IVideo
{
    private RealVideo _realVideo;
    private readonly string _filename;
    private readonly bool _isAuthorized;

    public ProxyVideo(string filename, bool isAuthorized)
    {
        _filename = filename;
        _isAuthorized = isAuthorized;
    }

    public void Play()
    {
        if (_isAuthorized)
        {
            if (_realVideo == null)
            {
                _realVideo = new RealVideo(_filename);
            }
            _realVideo.Play();
        }
        else
        {
            Console.WriteLine("Access denied. You are not authorized to view this video.");
        }
    }
}