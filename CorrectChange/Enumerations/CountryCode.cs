using System.ComponentModel;

namespace Yomisoft.CorrectChange.Enumerations
{
    /// <summary>
    /// Represents list of country codes using a two-letter format (ISO 3166-1 alpha-2)
    /// </summary>
    public enum CountryCode
    {
        [Description("Australia")]
        AU,

        [Description("Canada")]
        CA,

        [Description("United Kingdom")]
        UK,

        [Description("United States")]
        US
    }
}