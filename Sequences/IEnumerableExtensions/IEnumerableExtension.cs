using System;
using System.Collections.Generic;

/// <summary>
/// A classic set of IEnumerable query operators
/// </summary>
public static class IEnumerableExtension
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (T item in collection)
        {
            yield return func(item);
        }
    }
    
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (T item in collection)
        {
            if (predicate(item))
            {
                yield return item;
            }  
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (T item in collection)
        {
            if (!predicate(item))
            {
                yield return item;
            }
        }
    }
}