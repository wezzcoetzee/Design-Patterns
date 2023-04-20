using Singleton;

// Add an item to the cache
CacheManager.Instance.Add("key", "value");

// Retrieve an item from the cache
var value = CacheManager.Instance.Get("key") as string;

Console.WriteLine(value);

// Check if an item exists in the cache
var exists = CacheManager.Instance.Contains("key");

// Remove an item from the cache
CacheManager.Instance.Remove("key");

// Clear the entire cache
CacheManager.Instance.Clear();