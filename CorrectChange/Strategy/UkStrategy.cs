using System.Collections.Generic;
using Yomisoft.CorrectChange.Common;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Models;

namespace Yomisoft.CorrectChange.Strategy
{
    public class UkChange : ChangeStrategy
    {
        public override IEnumerable<string> CalculateChange(decimal due, decimal paid)
        {
            base.CalculateChange(due, paid);

            // Loop while change is than than or equal to 1¢.
            while (Change > Factory.GetDefaultDenomination().Value)
            {
                // Order is importan (largest to smallest)
                if (UpdateList(Factory.GetDenomination(CurrencyType.FiftyPence)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.TwentyPence)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.TenPence)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.TwoPence)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.OnePence)))
                    continue;
            }

            return ChangeList;
        }
    }
}