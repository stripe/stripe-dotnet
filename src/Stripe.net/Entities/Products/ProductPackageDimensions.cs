namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductPackageDimensions : StripeEntity<ProductPackageDimensions>
    {
        /// <summary>
        /// Height, in inches.
        /// </summary>
        [JsonProperty("height")]
        public decimal Height { get; set; }

        /// <summary>
        /// Length, in inches.
        /// </summary>
        [JsonProperty("length")]
        public decimal Length { get; set; }

        /// <summary>
        /// Weight, in ounces.
        /// </summary>
        [JsonProperty("weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// Width, in inches.
        /// </summary>
        [JsonProperty("width")]
        public decimal Width { get; set; }
    }
}
