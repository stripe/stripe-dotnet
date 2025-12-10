// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeySecretKey : StripeEntity<ApiKeySecretKey>
    {
        /// <summary>
        /// The encrypted secret for the API key. Only included when a key is first created.
        /// </summary>
        [JsonProperty("encrypted_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("encrypted_secret")]
#endif
        public ApiKeySecretKeyEncryptedSecret EncryptedSecret { get; set; }

        /// <summary>
        /// Redacted version of the secret token for display purposes.
        /// </summary>
        [JsonProperty("secret_token_redacted")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secret_token_redacted")]
#endif
        public string SecretTokenRedacted { get; set; }

        /// <summary>
        /// The plaintext token for the API key. Only included for testmode keys.
        /// </summary>
        [JsonProperty("token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("token")]
#endif
        public string Token { get; set; }
    }
}
