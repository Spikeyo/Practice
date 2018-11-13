//****************************************************************
// Solution for the Proverb exercise in Exercism.io
//
// ~Spikeyo
//****************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

namespace ProverbProject
{
    public static class Proverb
    {
        public static string[] Recite(string[] subjects)
        {
            if (subjects == null)
            {
                throw new ArgumentNullException(nameof(subjects), 
                    "subjects cannot be null");
            }

            var proverb = subjects.AddBody().AddEnd(subjects);
        
            return proverb.ToArray();
        }

        private static IEnumerable<string> AddBody(this string[] target)
        {
            var trimmedSubjects = target.SkipLast();
        
            return trimmedSubjects.Select((x, i) => $"For want of a {x} the {target[i + 1]} was lost.");
        }

        private static IEnumerable<string> AddEnd(this IEnumerable<string> target, string[] subjects)
        {
            if (subjects.Length > 0)
            {
                return target.Append($"And all for the want of a {subjects[0]}.");
            }
            else
            {
                return Enumerable.Empty<string>();
            }
        }

        private static IEnumerable<string> SkipLast(this IEnumerable<string> target)
        {
            return target.Take(target.Count() - 1);
        }

    }
}