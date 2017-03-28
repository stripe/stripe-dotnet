using Newtonsoft.Json;

namespace Stripe
{
    public class StripeProductListOptions : StripeListSelectedOptionsBase
    {
        /// <summary>
        /// Gets or sets a value idicating whether only active or inative products will be returned.  (e.g. pass false to list all inactive products).
        /// optional
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets a value idicating whether only shippable or non-shippable products will be returned.
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Gets or sets a url. Only return products with the given url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
