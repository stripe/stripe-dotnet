namespace Stripe
{
    using Newtonsoft.Json;

    public class SkuPackageDimensionsOptions : INestedOptions
    {
        /// <summary>
        /// Height, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// Length, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("length")]
        public decimal? Length { get; set; }

        /// <summary>
        /// Weight, in ounces. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("weight")]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Width, in inches. Maximum precision is 2 decimal places.
        /// </summary>
        [JsonProperty("width")]
        public decimal? Width { get; set; }
    }
}
