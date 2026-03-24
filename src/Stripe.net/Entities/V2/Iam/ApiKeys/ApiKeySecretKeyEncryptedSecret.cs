// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApiKeySecretKeyEncryptedSecret : StripeEntity<ApiKeySecretKeyEncryptedSecret>
    {
        /// <summary>
        /// The encrypted secret data in base64 format.
        /// </summary>
        [JsonProperty("ciphertext")]
        [STJS.JsonPropertyName("ciphertext")]
        public string Ciphertext { get; set; }

        /// <summary>
        /// The format of the encrypted secret (e.g., jwe_compact).
        /// </summary>
        [JsonProperty("format")]
        [STJS.JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// The caller's identifier of the public key provided.
        /// </summary>
        [JsonProperty("recipient_key_id")]
        [STJS.JsonPropertyName("recipient_key_id")]
        public string RecipientKeyId { get; set; }
    }
}
