// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApiKeyCreatePublicKeyPemKeyOptions : INestedOptions
    {
        /// <summary>
        /// The encryption algorithm used with this key (e.g., RSA).
        /// </summary>
        [JsonProperty("algorithm")]
        [STJS.JsonPropertyName("algorithm")]
        public string Algorithm { get; set; }

        /// <summary>
        /// The PEM-encoded public key data. Newlines are required between header/footer and body,
        /// and optional within the body.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
