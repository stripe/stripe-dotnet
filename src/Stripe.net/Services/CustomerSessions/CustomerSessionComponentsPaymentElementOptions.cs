// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionComponentsPaymentElementOptions : INestedOptions
    {
        /// <summary>
        /// Whether the payment element is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This hash defines whether the payment element supports certain features.
        /// </summary>
        [JsonProperty("features")]
        public CustomerSessionComponentsPaymentElementFeaturesOptions Features { get; set; }
    }
}
