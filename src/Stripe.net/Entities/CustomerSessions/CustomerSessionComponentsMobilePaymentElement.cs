// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerSessionComponentsMobilePaymentElement : StripeEntity<CustomerSessionComponentsMobilePaymentElement>
    {
        /// <summary>
        /// Whether the mobile payment element is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// This hash defines whether the mobile payment element supports certain features.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public CustomerSessionComponentsMobilePaymentElementFeatures Features { get; set; }
    }
}
