// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyRotateOptions : BaseOptions
    {
        /// <summary>
        /// Duration in minutes before the current key expires, with a maximum of 7 days (10080
        /// minutes). If not provided, the current key expires immediately.
        /// </summary>
        [JsonProperty("expire_current_key_in_minutes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expire_current_key_in_minutes")]
#endif
        public long? ExpireCurrentKeyInMinutes { get; set; }

        /// <summary>
        /// Public key for encrypting the new API key secret. This must a PEM-formatted RSA key
        /// suitable for encryption, &gt;= 2048 bits. A public key is required when rotating secret
        /// keys. Publishable keys are not encrypted and a public key should not be included.
        /// </summary>
        [JsonProperty("public_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("public_key")]
#endif
        public ApiKeyRotatePublicKeyOptions PublicKey { get; set; }
    }
}
