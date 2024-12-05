// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPaymentElement : StripeEntity<CustomerSessionComponentsPaymentElement>
    {
        /// <summary>
        /// Whether the Payment Element is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// This hash defines whether the Payment Element supports certain features.
        /// </summary>
        [JsonProperty("features")]
        public CustomerSessionComponentsPaymentElementFeatures Features { get; set; }
    }
}
