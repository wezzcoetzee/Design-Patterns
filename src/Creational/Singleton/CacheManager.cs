namespace Singleton;

public sealed class CacheManager
{
    private static CacheManager _instance = null!;
    private static readonly object LockObject = new object();

    private readonly Dictionary<string, object> _cache;

    private CacheManager()
    {
        _cache = new Dictionary<string, object>();
    }

    public static CacheManager Instance
    {
        get
        {
            lock(LockObject)
            {
                if (_instance == null)
                {
                    _instance = new CacheManager();
                }
            }
            return _instance;
        }
    }

    public void Add(string key, object value)
    {
        _cache[key] = value;
    }

    public object? Get(string key)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            return value;
        }
        else
        {
            return null;
        }
    }

    public bool Contains(string key)
    {
        return _cache.ContainsKey(key);
    }

    public void Remove(string key)
    {
        if (_cache.ContainsKey(key))
        {
            _cache.Remove(key);
        }
    }

    public void Clear()
    {
        _cache.Clear();
    }
}