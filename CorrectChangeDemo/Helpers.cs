using System;
using System.Collections.Generic;

namespace CorrectChangeDemo
{
    internal static class Helpers
    {

        public enum CountryCode
        {
            USA
        }

        public enum DenominationUSA
        {
            Penny = 01,
            Nickel = 05,
            Dime = 10,
            Quarter = 25
        }

        // IEnumerable lacks a ForEach Linq operator extension method
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T item in sequence) action(item);
        }

    }
}