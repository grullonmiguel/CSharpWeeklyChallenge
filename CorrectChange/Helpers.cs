using System;
using System.Collections.Generic;

namespace Yomisoft.CorrectChange
{
    internal static class Helpers
    {
        public enum DenominationUSA
        {
            Penny = 01,
            Nickel = 05,
            Dime = 10,
            Quarter = 25
        }

        // IEnumerable lacks a ForEach LINQ operator extension method
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence) action(item);
        }

    }
}