// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPaymentElement : StripeEntity<CustomerSessionComponentsPaymentElement>
    {
        /// <summary>
        /// Whether the payment element is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// This hash contains the features the Payment Element supports.
        /// </summary>
        [JsonProperty("features")]
        public CustomerSessionComponentsPaymentElementFeatures Features { get; set; }
    }
}
