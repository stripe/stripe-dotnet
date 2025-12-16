// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyListOptions : V2.ListOptions
    {
        /// <summary>
        /// Whether to include expired API keys in the response.
        /// </summary>
        [JsonProperty("include_expired")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include_expired")]
#endif
        public bool? IncludeExpired { get; set; }
    }
}
