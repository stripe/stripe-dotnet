// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountExternalAccountCardTokenOptions : INestedOptions, IHasObject
    {
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; } = "card";

        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        [JsonProperty("token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token")]
#endif

        public string Token { get; set; }
    }
}
