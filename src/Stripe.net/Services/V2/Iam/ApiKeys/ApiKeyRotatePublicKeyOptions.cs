// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApiKeyRotatePublicKeyOptions : INestedOptions, IHasId
    {
        /// <summary>
        /// Caller's identifier of the public key. This is used for tracking purposes only, and will
        /// be echoed in the response if provided.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// PEM-formatted public key.
        /// </summary>
        [JsonProperty("pem_key")]
        [STJS.JsonPropertyName("pem_key")]
        public ApiKeyRotatePublicKeyPemKeyOptions PemKey { get; set; }
    }
}
