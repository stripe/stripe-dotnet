// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionAutomaticTax : StripeEntity<SubscriptionAutomaticTax>
    {
        /// <summary>
        /// Whether Stripe automatically computes tax on this subscription.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
