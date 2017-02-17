using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDimensions
    {
        /// <summary>
        /// v2017-01-27: Gets or sets the height, in inches
        /// </summary>
        [JsonProperty("height")]
        public decimal Height { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets the length, in inches
        /// </summary>
        [JsonProperty("length")]
        public decimal Length { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets the weight, in ounces
        /// </summary>
        [JsonProperty("weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets the width, in inches
        /// </summary>
        [JsonProperty("width")]
        public decimal Width { get; set; }
    }
}
