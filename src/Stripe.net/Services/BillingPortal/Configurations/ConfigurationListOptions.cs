// File generated from our OpenAPI spec
namespace Stripe.BillingPortal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationListOptions : ListOptions
    {
        /// <summary>
        /// Only return configurations that are active or inactive (e.g., pass <c>true</c> to only
        /// list active configurations).
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif
        public bool? Active { get; set; }

        /// <summary>
        /// Only return the default or non-default configurations (e.g., pass <c>true</c> to only
        /// list the default configuration).
        /// </summary>
        [JsonProperty("is_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_default")]
#endif
        public bool? IsDefault { get; set; }
    }
}
