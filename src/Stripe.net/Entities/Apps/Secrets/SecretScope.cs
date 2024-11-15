// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SecretScope : StripeEntity<SecretScope>
    {
        /// <summary>
        /// The secret scope type.
        /// One of: <c>account</c>, or <c>user</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        /// <summary>
        /// The user ID, if type is set to "user".
        /// </summary>
        [JsonProperty("user")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user")]
#endif

        public string User { get; set; }
    }
}
