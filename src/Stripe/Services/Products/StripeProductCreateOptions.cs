using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Stripe product creation parameters
    /// </summary>
    public class StripeProductCreateOptions : StripeProductUpdateOptions
    {
        /// <summary>
        /// Gets or sets the procut id.
        /// optional
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a list of up to 5 alphanumeric attributes that each SKU can provide values for (e.g. ["color", "size"]).
        /// Optional
        /// </summary>
        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }
    }
}
