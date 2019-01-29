using System.Collections.Generic;

namespace CorrectChangeDemo
{
    internal interface IChangeCalculator
    {
        decimal Change { get; }

        List<string> List { get; }

        IEnumerable<string> CalculateChange(decimal amountOwed, decimal amountPaid);
    }
}