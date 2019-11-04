using System.Collections.Generic;
using Yomisoft.CorrectChange.Common;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Models;

namespace Yomisoft.CorrectChange.Strategy
{
    public class CaStrategy : ChangeStrategy
    {
        public override IEnumerable<string> CalculateChange(decimal due, decimal paid)
        {
            base.CalculateChange(due, paid);

            // Canadian penny was discontinued in 2012. 
            // The smallest Canadian coin is the nickel.
            // Loop while change is more than or equals to 5¢.
            while (Change >= Factory.GetDenomination(CurrencyType.Nickel).Value)
            {
                // Order is importan (largest to smallest)
                if (UpdateList(Factory.GetDenomination(CurrencyType.FiftyCent)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.Quarter)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.Dime)))
                    continue;

                if (UpdateList(Factory.GetDenomination(CurrencyType.Nickel)))
                    continue;
            }

            return ChangeList;
        }
    }
}