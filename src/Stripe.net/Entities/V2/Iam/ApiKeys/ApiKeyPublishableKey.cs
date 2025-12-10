// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyPublishableKey : StripeEntity<ApiKeyPublishableKey>
    {
        /// <summary>
        /// The plaintext token for the API key.
        /// </summary>
        [JsonProperty("token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token")]
#endif
        public string Token { get; set; }
    }
}
