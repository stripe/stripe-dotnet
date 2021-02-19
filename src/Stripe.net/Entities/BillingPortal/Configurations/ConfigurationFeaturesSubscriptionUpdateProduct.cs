// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationFeaturesSubscriptionUpdateProduct : StripeEntity<ConfigurationFeaturesSubscriptionUpdateProduct>
    {
        /// <summary>
        /// The product ID.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }
    }
}
