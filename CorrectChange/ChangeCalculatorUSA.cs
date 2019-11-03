using System;
using System.Collections.Generic;
using static Yomisoft.CorrectChange.Helpers;

namespace Yomisoft.CorrectChange
{
    internal class ChangeCalculatorUSA : IChangeCalculator
    {
                
        public decimal Change { get; private set; }

        public List<string> List { get; private set; }

        public IEnumerable<string> CalculateChange(decimal amountOwed, decimal amountPaid)
        {
            // The amount to pay must be greater
            if (amountOwed > amountPaid)
            {
                throw new Exception("Not enough money...");
            }

            // The change to calculate
            Change = amountPaid - amountOwed;
            
            // The list to return
            List = new List<string>();

            while (Change > 0.00m)
            {
                if (Change >= .25m)
                {
                    AddToList(DenominationUSA.Quarter);
                    continue;
                }
                if (Change >= .10m)
                {
                    AddToList(DenominationUSA.Dime);
                    continue;
                }
                if (Change >= .05m)
                {
                    AddToList(DenominationUSA.Nickel);
                    continue;
                }
                if (Change >= .01m)
                {
                    AddToList(DenominationUSA.Penny);
                    continue;
                }
            }

            return List;
        }

        private void AddToList(DenominationUSA denomination)
        {
            List.Add(denomination.ToString());
            Change -= (decimal)denomination / 100; 
        }
    }
}