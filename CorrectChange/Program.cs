using System;
using System.Collections.Generic;
using Yomisoft.CorrectChange.Common;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Interfaces;

/// <summary>
/// C# Weekly Challenges
/// https://www.iamtimcorey.com/p/c-weekly-challenges
/// https://www.youtube.com/watch?v=bX6PN6Cfe-k&t=54s
/// </summary>
namespace Yomisoft.CorrectChange
{
    /// <summary>
    /// Create a Console application that takes in an 
    /// amount owed and an amount paid.
    /// 
    /// Have the application calculate how much change 
    /// a person is due. Just worry about change under a dollar.
    /// </summary>
    public class Program
    {
        #region Properties

        /// <summary>
        /// Gets the amount owed by the customer
        /// </summary>
        private static decimal AmountDue { get; } = .41m;

        /// <summary>
        /// Gets the amount paid by the customer
        /// </summary>
        private static decimal AmountPaid { get; } = .97m;

        /// <summary>
        /// Gets or sets a list of change
        /// </summary>
        private static IEnumerable<string> ChangeList { get; set; }

        /// <summary>
        /// Gets or sets a reference to a <see cref="Transaction"/> object
        /// </summary>
        private static ITransaction Transaction { get; set; }

        #endregion

        /// <summary>
        /// Entry point to the application
        /// </summary>
        private static void Main()
        {
            try
            {
                // Display information on screen
                DisplayTransaction();

                // Create instance of a transaction / update amounts
                Transaction = Factory.GetTransaction(CountryCode.US);
                Transaction.UpdateAmountDue(AmountDue);
                Transaction.UpdateAmountPaid(AmountPaid);

                // Display change for US
                DisplayChange();

                // Change country code to Canada / display change
                Transaction.UpdateDenomination(CountryCode.CA);
                DisplayChange();

                // Change country code to UK / display change
                Transaction.UpdateDenomination(CountryCode.UK);
                DisplayChange();

                // Change country code to AU / display change
                Transaction.UpdateDenomination(CountryCode.AU);
                DisplayChange();
            }
            catch (Exception e)
            {
                Factory.Output(e.Message.ToString());
            }
            finally
            {
                Factory.Pause();
            }
        }

        /// <summary>
        /// Display transaction information on the screen
        /// </summary>
        private static void DisplayTransaction()
        {
            Factory.Output($"Amount Due: {AmountDue}");
            Factory.Output($"Amount Paid: {AmountPaid}");
            Factory.Output($"Change: {AmountPaid - AmountDue}");
        }

        /// <summary>
        /// Display change information on the screen
        /// </summary>
        private static void DisplayChange()
        {
            // Call the calculate method change
            ChangeList = Transaction.CalculateChange();

            // Iterate through the list and display information
            ChangeList.ForEach(x => Factory.Output(x));
        }
    }
}