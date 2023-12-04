using System;
using System.Collections.Generic;

class Cache
{
    private static Dictionary<int, object> _cache = new Dictionary<int, object>();
    private static int MaxCacheSize = 10000; 

    public static void Add(int key, object value)
    {
        _cache.Add(key, value);
        CacheLimit();
    }

    public static object Get(int key)
    {
        return _cache[key];
    }

    private static void CacheLimit()
    {
        if (_cache.Count > MaxCacheSize)
        {

            var keysToRemove = new List<int>(_cache.Keys);
            keysToRemove.Sort();

            foreach (var key in keysToRemove)
            {
                _cache.Remove(key);
                if (_cache.Count <= MaxCacheSize)
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                Cache.Add(i, new object());
            }

            Console.WriteLine("Cache populated");

            Console.ReadLine();
        }
    }
}