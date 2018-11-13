using System;
using System.Collections.Generic;

/// <summary>
/// A classic Accumulate function without LINQ
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
}