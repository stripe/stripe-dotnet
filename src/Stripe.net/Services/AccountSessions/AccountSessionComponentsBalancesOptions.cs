// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsBalancesOptions : INestedOptions
    {
        /// <summary>
        /// Whether the embedded component is enabled.
        /// </summary>
        [JsonProperty("enabled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enabled")]
#endif
        public bool? Enabled { get; set; }

        /// <summary>
        /// The list of features enabled in the embedded component.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif
        public AccountSessionComponentsBalancesFeaturesOptions Features { get; set; }
    }
}
