// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeySecretKeyEncryptedSecret : StripeEntity<ApiKeySecretKeyEncryptedSecret>
    {
        /// <summary>
        /// The encrypted secret data in base64 format.
        /// </summary>
        [JsonProperty("ciphertext")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ciphertext")]
#endif
        public string Ciphertext { get; set; }

        /// <summary>
        /// The format of the encrypted secret (e.g., jwe_compact).
        /// </summary>
        [JsonProperty("format")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("format")]
#endif
        public string Format { get; set; }

        /// <summary>
        /// The caller's identifier of the public key provided.
        /// </summary>
        [JsonProperty("recipient_key_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recipient_key_id")]
#endif
        public string RecipientKeyId { get; set; }
    }
}
