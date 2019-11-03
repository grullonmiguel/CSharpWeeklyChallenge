using System;
using Yomisoft.CorrectChange.Enumerations;

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