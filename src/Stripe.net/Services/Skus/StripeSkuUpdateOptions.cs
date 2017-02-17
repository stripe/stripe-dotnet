using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Sku update parameters.
    /// </summary>
    public class StripeSkuUpdateOptions : StripeSkuOptionsBase
    {
        /// <summary>
        /// Gets or sets the cost of the item as a positive integer in the smallest currency unit (that is, 100 cents to charge $1.00, or 100 to charge ¥100, Japanese Yen being a 0-decimal currency).
        /// </summary>
        [JsonProperty("price")]
        public uint? Price { get; set; }
    }
}
