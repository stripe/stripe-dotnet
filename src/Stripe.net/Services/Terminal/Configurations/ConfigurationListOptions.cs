// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfigurationListOptions : ListOptions
    {
        /// <summary>
        /// if present, only return the account default or non-default configurations.
        /// </summary>
        [JsonProperty("is_account_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_account_default")]
#endif
        public bool? IsAccountDefault { get; set; }
    }
}
