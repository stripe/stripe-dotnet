// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApiKeySecretKey : StripeEntity<ApiKeySecretKey>
    {
        /// <summary>
        /// The encrypted secret for the API key. Only included when a key is first created.
        /// </summary>
        [JsonProperty("encrypted_secret")]
        [STJS.JsonPropertyName("encrypted_secret")]
        public ApiKeySecretKeyEncryptedSecret EncryptedSecret { get; set; }

        /// <summary>
        /// Redacted version of the secret token for display purposes.
        /// </summary>
        [JsonProperty("secret_token_redacted")]
        [STJS.JsonPropertyName("secret_token_redacted")]
        public string SecretTokenRedacted { get; set; }

        /// <summary>
        /// The plaintext token for the API key. Only included for testmode keys.
        /// </summary>
        [JsonProperty("token")]
        [STJS.JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
