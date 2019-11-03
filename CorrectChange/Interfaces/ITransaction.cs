using Yomisoft.CorrectChange.Enumerations;

namespace Yomisoft.CorrectChange.Interfaces
{
    public interface ITransaction
    {
        IDenomination Denomination { get; }

        decimal Owed { get; }

        decimal Paid { get; }

        void SetDenomination(CountryCode code);
    }
}