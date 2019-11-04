using System.ComponentModel;

namespace Yomisoft.CorrectChange.Enumerations
{
    /// <summary>
    /// Represents list of denominations
    /// </summary>
    public enum CurrencyType
    {// US and Canada Coins
        [Description("None")]
        None,

        // US and Canada Coins
        [Description("Penny")]
        Penny,

        [Description("Nickel")]
        Nickel,

        [Description("Dime")]
        Dime,

        [Description("Quarter")]
        Quarter,

        [Description("50 Cents")]
        FiftyCent,

        // UK Coins
        [Description("1p")]
        OnePence,

        [Description("2p")]
        TwoPence,

        [Description("10p")]
        TenPence,

        [Description("20p")]
        TwentyPence,

        [Description("50p")]
        FiftyPence,

        // Australia Coins
        [Description("5c")]
        FiveC,

        [Description("10c")]
        TenC,

        [Description("20c")]
        TwentyC,

        [Description("50c")]
        FiftyC

    }
}
