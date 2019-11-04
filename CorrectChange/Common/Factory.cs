using System;
using Yomisoft.CorrectChange.Enumerations;
using Yomisoft.CorrectChange.Interfaces;
using Yomisoft.CorrectChange.Models;
using Yomisoft.CorrectChange.Strategy;

namespace Yomisoft.CorrectChange.Common
{
    public class Factory
    {
        /// <summary>
        /// Gets a <see cref="Transaction"/> instance using the specified <see cref="CountryCode"/>
        /// </summary>
        public static ITransaction GetTransaction(CountryCode code) => new Transaction(code);

        /// <summary>
        /// Gets a <see cref="ChangeStrategy"/> instance using the specified <see cref="CountryCode"/>
        /// </summary>
        public static IChangeStrategy GetCountryStrategy(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.AU:
                    return new AuStrategy();

                case CountryCode.CA:
                    return new CaStrategy();

                case CountryCode.US:
                    return new UsStrategy();

                case CountryCode.UK:
                    return new UkChange();

                default:
                    return new UsStrategy();
            }
        }

        /// <summary>
        /// Gets a <see cref="Denomination"/> instance using the specified <see cref="CurrencyType"/>
        /// </summary>
        public static Denomination GetDenomination(CurrencyType currency)
        {
            switch (currency)
            {
                case CurrencyType.Penny:
                case CurrencyType.OnePence:
                    return new Denomination(.01m, currency.GetDescription());

                case CurrencyType.FiveC:
                case CurrencyType.Nickel:
                    return new Denomination(.05m, currency.GetDescription());

                case CurrencyType.Quarter:
                    return new Denomination(.25m, currency.GetDescription());
                    
                case CurrencyType.TwoPence:
                    return new Denomination(.02m, currency.GetDescription());

                case CurrencyType.Dime:
                case CurrencyType.TenC:
                case CurrencyType.TenPence:
                    return new Denomination(.10m, currency.GetDescription());

                case CurrencyType.TwentyC:
                case CurrencyType.TwentyPence:
                    return new Denomination(.20m, currency.GetDescription());

                case CurrencyType.FiftyC:
                case CurrencyType.FiftyCent:
                case CurrencyType.FiftyPence:
                    return new Denomination(.50m, currency.GetDescription());

                default:
                    return new Denomination(.00m, currency.GetDescription());
            }
        }

        public static Denomination GetDefaultDenomination() => GetDenomination(CurrencyType.None);

        /// <summary>
        /// Outputs message to the screen
        /// </summary>
        public static void Output(string value) => Console.WriteLine(value);

        /// <summary>
        /// Pauses the console screen to prevent the screen from closing
        /// </summary>
        public static void Pause() => Console.ReadLine();
    }
}