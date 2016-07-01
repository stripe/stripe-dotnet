using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Package dimensions.
    /// </summary>
    public class StripeDimensions
    {
        /// <summary>
        /// Gets or sets the height, in inches
        /// </summary>
        [JsonProperty("height")]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the length, in inches
        /// </summary>
        [JsonProperty("length")]
        public decimal Length { get; set; }

        /// <summary>
        /// Gets or sets the weight, in ounces
        /// </summary>
        [JsonProperty("weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets the width, in inches
        /// </summary>
        [JsonProperty("width")]
        public decimal Width { get; set; }
    }
}
