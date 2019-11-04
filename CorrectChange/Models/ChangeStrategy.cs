using System;
using System.Collections.Generic;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Interfaces;

namespace Yomisoft.CorrectChange.Models
{
    public abstract class ChangeStrategy : IChangeStrategy
    {
        #region Properties

        /// <summary>
        /// The change to return
        /// </summary>
        public decimal Change { get; set; }

        /// <summary>
        /// The list of change to return
        /// </summary>
        public List<string> ChangeList { get; set; }

        public List<Denomination> CoinList { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChangeStrategy()
        {
            ChangeList = new List<string>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the change to return
        /// </summary>
        public virtual IEnumerable<string> CalculateChange(decimal due, decimal paid)
        {
            // Amount to pay must be greater
            if (due >= paid)
                throw new Exception("Not enough money...");

            // The change to calculate
            Change = paid - due;

            return ChangeList;
        }

        /// <summary>
        /// Updates the change list
        /// </summary>
        public bool UpdateList(Denomination coin)
        {
            // Change must be greater than value
            if (coin.Value > Change)
                return false;

            // Add change to the list
            ChangeList.Add(coin.Description);

            // decrement the change
            Change -= coin.Value;
            return true;
        }
        
        /// <summary>
        /// Converts a <see cref="CurrencyType"/> value to <see cref="decimal"/> value
        /// </summary>
        private decimal CurrencyToDecimal(CurrencyType value) => (decimal)value / 100;

        #endregion

    }
}