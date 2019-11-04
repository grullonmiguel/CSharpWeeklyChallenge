using System.Collections.Generic;
using Yomisoft.CorrectChange.Common;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Interfaces;

namespace Yomisoft.CorrectChange
{
    public class Transaction : ITransaction
    {
        #region Properties

        /// <summary>
        /// Gets or sets the denomination
        /// </summary>
        public IChangeStrategy Denomination { get; private set; }

        /// <summary>
        /// Gets or sets the amount due
        /// </summary>
        public decimal Due { get; private set; }

        /// <summary>
        /// Gets or sets the amount paid
        /// </summary>
        public decimal Paid { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public Transaction(CountryCode code)
        {
            UpdateDenomination(code);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the change by calling the specified Denomination Calculate method
        /// </summary>
        public IEnumerable<string> CalculateChange() => Denomination.CalculateChange(Due, Paid);

        /// <summary>
        /// Updates the Denomination
        /// </summary>
        public void UpdateDenomination(CountryCode code)
        {
            Denomination = Factory.GetCountryStrategy(code);

            Factory.Output($"\n{code.GetDescription()}:\n");
        }

        /// <summary>
        /// Updates the amount due
        /// </summary>
        public void UpdateAmountDue(decimal value) => Due = value;

        /// <summary>
        /// Updates the amount paid
        /// </summary>
        public void UpdateAmountPaid(decimal value) => Paid = value;

        #endregion
    }
}