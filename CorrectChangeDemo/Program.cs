using System;
using static CorrectChangeDemo.Helpers;

namespace CorrectChangeDemo
{
    internal class Program
    {

        const decimal AMOUNT_OWED = .39m;
        const decimal AMOUNT_PAID = .49m;

        static void Main(string[] args)
        {
            try
            {
                var calculator = Factory.GetCalculator(CountryCode.USA);

                var results = calculator.CalculateChange(AMOUNT_OWED, AMOUNT_PAID);

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