// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionAdaptivePricing : StripeEntity<SessionAdaptivePricing>
    {
        /// <summary>
        /// Whether Adaptive Pricing is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
