using System.Collections.Generic;
using Yomisoft.CorrectChange.Interfaces;

namespace Yomisoft.CorrectChange.Models
{
    public abstract class ChangeStrategy : IChange
    {
        public abstract IEnumerable<string> CalculateChange(decimal owed, decimal paid);
    }
}
