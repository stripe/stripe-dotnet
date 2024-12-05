// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;

    public class ConfigurationFeaturesInvoiceHistory : StripeEntity<ConfigurationFeaturesInvoiceHistory>
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
