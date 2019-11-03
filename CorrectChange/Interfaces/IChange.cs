using System.Collections.Generic;

namespace Yomisoft.CorrectChange.Interfaces
{
    public interface IChange
    {
        IEnumerable<string> CalculateChange(decimal owed, decimal paid);
    }
}