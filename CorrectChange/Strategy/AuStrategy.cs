using System.Collections.Generic;
using Yomisoft.CorrectChange.Common;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Models;

namespace Yomisoft.CorrectChange.Strategy
{
    public class AuStrategy : ChangeStrategy
    {
        public override IEnumerable<string> CalculateChange(decimal due, decimal paid)
        {
            base.CalculateChange(due, paid);

            // The one- and two-cent coins were discontinued in 1991 due to the
            // metal exceeding face value and were withdrawn from circulation.
            // Loop while change is more than or equals to 5¢.
            while (Change >= Factory.GetDenomination(CurrencyType.FiveC).Value)
            {
                // Order is importan (largest to smallest)
                if (UpdateList(Factory.GetDenomination(CurrencyType.FiftyC)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.TwentyC)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.TenC)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.FiveC)))
                    continue;
            }

            return ChangeList;
        }
    }
}