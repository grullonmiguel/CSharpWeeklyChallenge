using CorrectChangeDemo.Enumerations;
using static CorrectChangeDemo.Helpers;

namespace CorrectChangeDemo
{
    internal class Factory
    {
        public static IChangeCalculator GetCalculator(CountryCode country)
        {

            switch (country)
            {
                case CountryCode.US:
                    return new ChangeCalculatorUSA();
          
                default:
                    throw new System.Exception("Country Code is not valid");
            }

        }
    }
}