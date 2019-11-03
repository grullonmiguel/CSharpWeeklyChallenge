using Yomisoft.CorrectChange.Enumerations;

namespace Yomisoft.CorrectChange
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