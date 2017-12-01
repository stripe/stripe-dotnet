using Newtonsoft.Json;

namespace Stripe
{
    public class StripeProductCreateOptions : StripeProductSharedOptions
    {
        /// <summary>
        /// The identifier for the product. Must be unique. If not provided, an identifier will be randomly generated.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The type of the product. Either 'service' or 'good'.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
