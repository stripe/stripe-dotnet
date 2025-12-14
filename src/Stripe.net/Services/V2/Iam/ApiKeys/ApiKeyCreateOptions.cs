// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyCreateOptions : BaseOptions
    {
        /// <summary>
        /// Name for the API key.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Note or description for the API key.
        /// </summary>
        [JsonProperty("note")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("note")]
#endif
        public string Note { get; set; }

        /// <summary>
        /// Public key for encrypting the API key secret. This must a PEM-formatted RSA key suitable
        /// for encryption, &gt;= 2048 bits. A public key is required when creating secret keys.
        /// Publishable keys are not encrypted and a public key should not be included.
        /// </summary>
        [JsonProperty("public_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("public_key")]
#endif
        public ApiKeyCreatePublicKeyOptions PublicKey { get; set; }

        /// <summary>
        /// Type of the API key to create (secret or publishable).
        /// One of: <c>publishable_key</c>, or <c>secret_key</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
