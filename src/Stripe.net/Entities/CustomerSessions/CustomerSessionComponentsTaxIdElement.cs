// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionComponentsTaxIdElement : StripeEntity<CustomerSessionComponentsTaxIdElement>
    {
        /// <summary>
        /// Whether the Tax ID Element is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool Enabled { get; set; }

        /// <summary>
        /// This hash defines whether the Tax ID Element supports certain features.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif
        public CustomerSessionComponentsTaxIdElementFeatures Features { get; set; }
    }
}
