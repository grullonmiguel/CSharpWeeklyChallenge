namespace Yomisoft.CorrectChange.Models
{
    public class Denomination
    {
        /// <summary>
        /// Gets or sets the coin value
        /// </summary>
        public decimal Value { get; private set; }

        /// <summary>
        /// Gets or sets the coin description
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Denomination(decimal value, string desc)
        {
            Value = value;
            Description = desc;
        }
    }
}