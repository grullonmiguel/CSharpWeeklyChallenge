using CorrectChangeDemo.Enumerations;
using System;
using static CorrectChangeDemo.Helpers;

namespace CorrectChangeDemo
{
    /// <summary>
    /// Create a Console app that takes in an amount owed and an amount paid.
    /// Have the app calculate how change a person is due.
    /// Just worry about change under a dollar.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Gets the amount owed by the customer
        /// </summary>
        private static decimal AmountOwed { get; } = .41m;

        /// <summary>
        /// Gets the amount paid by the customer
        /// </summary>
        private static decimal AmountPaid { get; } = .49m;

        /// <summary>
        /// Entry point to the application
        /// </summary>
        private static void Main()
        {
            try
            {
                IChangeCalculator calculator = Factory.GetCalculator(CountryCode.US);

                var results = calculator.CalculateChange(AmountOwed, AmountPaid);

                results.ForEach(x => Console.WriteLine(x));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}