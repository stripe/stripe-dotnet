// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyCreatePublicKeyOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// Caller's identifier of the public key. This is used for tracking purposes only, and will
        /// be echoed in the response if provided.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// PEM-formatted public key.
        /// </summary>
        [JsonProperty("pem_key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pem_key")]
#endif
        public ApiKeyCreatePublicKeyPemKeyOptions PemKey { get; set; }
    }
}
