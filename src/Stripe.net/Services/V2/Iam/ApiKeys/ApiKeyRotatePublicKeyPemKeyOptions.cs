// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyRotatePublicKeyPemKeyOptions : INestedOptions
    {
        /// <summary>
        /// The encryption algorithm used with this key (e.g., RSA).
        /// </summary>
        [JsonProperty("algorithm")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("algorithm")]
#endif
        public string Algorithm { get; set; }

        /// <summary>
        /// The PEM-encoded public key data. Newlines are required between header/footer and body,
        /// and optional within the body.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif
        public string Data { get; set; }
    }
}
