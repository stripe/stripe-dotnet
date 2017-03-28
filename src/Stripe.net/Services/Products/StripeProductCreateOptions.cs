using Newtonsoft.Json;

namespace Stripe
{
    public class StripeProductCreateOptions : StripeProductUpdateOptions
    {
        /// <summary>
        /// Gets or sets the procut id.
        /// optional
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
