using System;
using System.Collections.Generic;

namespace EnumerableExtensionProject
{
    /// <summary>
    /// A classic set of IEnumerable query operators
    /// </summary>
    public static class EnumerableExtension
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
}