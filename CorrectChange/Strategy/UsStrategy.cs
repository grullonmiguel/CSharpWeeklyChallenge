using System.Collections.Generic;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Models;
using Yomisoft.CorrectChange.Common;

namespace Yomisoft.CorrectChange.Strategy
{
    public class UsStrategy : ChangeStrategy
    {
        public override IEnumerable<string> CalculateChange(decimal due, decimal paid)
        {
            base.CalculateChange(due, paid);

            // Loop while change is than than or equal to 1¢.
            while (Change > Factory.GetDefaultDenomination().Value)
            {
                // Order is importan (largest to smallest)
                if (UpdateList(Factory.GetDenomination(CurrencyType.Quarter)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.Dime)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.Nickel)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.Penny)))
                    continue;
            }

            return ChangeList;
        }
    }
}