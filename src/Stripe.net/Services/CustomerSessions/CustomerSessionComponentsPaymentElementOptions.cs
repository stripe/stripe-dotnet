// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerSessionComponentsPaymentElementOptions : INestedOptions
    {
        /// <summary>
        /// Whether the Payment Element is enabled.
        /// </summary>
        [JsonProperty("enabled")]
        [STJS.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This hash defines whether the Payment Element supports certain features.
        /// </summary>
        [JsonProperty("features")]
        [STJS.JsonPropertyName("features")]
        public CustomerSessionComponentsPaymentElementFeaturesOptions Features { get; set; }
    }
}
