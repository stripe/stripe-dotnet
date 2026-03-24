// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConfigurationFeaturesInvoiceHistory : StripeEntity<ConfigurationFeaturesInvoiceHistory>
    {
        /// <summary>
        /// Whether the feature is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
