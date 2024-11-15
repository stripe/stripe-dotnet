// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionComponentsPaymentElementOptions : INestedOptions
    {
        /// <summary>
        /// Whether the Payment Element is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif

        public bool? Enabled { get; set; }

        /// <summary>
        /// This hash defines whether the Payment Element supports certain features.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif

        public CustomerSessionComponentsPaymentElementFeaturesOptions Features { get; set; }
    }
}
