using System.Collections.Generic;
using Yomisoft.CorrectChange.Enumerations;

namespace Yomisoft.CorrectChange.Interfaces
{
    public interface ITransaction
    {
        IChangeStrategy Denomination { get; }

        decimal Due { get; }

        decimal Paid { get; }

        IEnumerable<string> CalculateChange();

        void UpdateAmountDue(decimal value);

        void UpdateAmountPaid(decimal value);

        void UpdateDenomination(CountryCode code);
    }
}