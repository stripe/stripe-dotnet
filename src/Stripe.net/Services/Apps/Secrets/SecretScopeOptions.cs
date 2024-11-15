// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SecretScopeOptions : INestedOptions
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
        /// The user ID. This field is required if <c>type</c> is set to <c>user</c>, and should not
        /// be provided if <c>type</c> is set to <c>account</c>.
        /// </summary>
        [JsonProperty("user")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user")]
#endif

        public string User { get; set; }
    }
}
