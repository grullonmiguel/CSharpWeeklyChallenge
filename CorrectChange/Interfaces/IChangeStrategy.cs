using System.Collections.Generic;
using Yomisoft.CorrectChange.Models;

namespace Yomisoft.CorrectChange.Interfaces
{
    public interface IChangeStrategy
    {
        decimal Change { get; set; }

        List<string> ChangeList { get; set; }

        IEnumerable<string> CalculateChange(decimal due, decimal paid);

        bool UpdateList(Denomination coin);
    }
}