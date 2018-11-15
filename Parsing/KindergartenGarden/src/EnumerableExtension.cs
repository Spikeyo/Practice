using System.Collections.Generic;

namespace KindergartenGardenProject
{
    public static class EnumerableExtension
    {
        public static IEnumerable<IEnumerable<T>> Partition<T>(this IEnumerable<T> input, int blockSize)
        {
            var enumerator = input.GetEnumerator();

            while (enumerator.MoveNext())
            {
                yield return GetNextPartition(enumerator, blockSize);
            }
            
        }

        private static IEnumerable<T> GetNextPartition<T>(IEnumerator<T> enumerator, int blockSize)
        {
            do
            {
                yield return enumerator.Current;
            }
            while (--blockSize > 0 && enumerator.MoveNext());
        }
    }
}