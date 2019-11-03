using System.Collections.Generic;
using Yomisoft.CorrectChange.Enumerations;

namespace Yomisoft.CorrectChange.Interfaces
{
    public interface ITransaction
    {
        IChange Denomination { get; }

        decimal Owed { get; }

        decimal Paid { get; }

        IEnumerable<string> CalculateChange();

        void SetDenomination(CountryCode code);
    }
}