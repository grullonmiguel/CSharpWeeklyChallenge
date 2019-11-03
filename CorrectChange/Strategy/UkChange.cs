using System.Collections.Generic;
using Yomisoft.CorrectChange.Models;

namespace Yomisoft.CorrectChange.Strategy
{
    public class UkChange : ChangeStrategy
    {
        public override IEnumerable<string> CalculateChange(decimal owed, decimal paid)
        {
            return new List<string>();
        }
    }
}
