// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProviderConnectionRequestCreateOptions : BaseOptions
    {
        /// <summary>
        /// PKCE code challenge: BASE64URL(SHA256(code_verifier)). Optional; when present the OAuth
        /// callback must supply the matching code_verifier. Not a secret (it is a hash of the
        /// verifier).
        /// </summary>
        [JsonProperty("code_challenge")]
        [STJS.JsonPropertyName("code_challenge")]
        public string CodeChallenge { get; set; }

        /// <summary>
        /// PKCE code challenge method. Only "S256" is supported.
        /// </summary>
        [JsonProperty("code_challenge_method")]
        [STJS.JsonPropertyName("code_challenge_method")]
        public string CodeChallengeMethod { get; set; }

        /// <summary>
        /// Provider-specific configuration payload for the connection.
        /// </summary>
        [JsonProperty("configuration")]
        [STJS.JsonPropertyName("configuration")]
        public Dictionary<string, object> Configuration { get; set; }

        /// <summary>
        /// Project this provider connection is created for. Used to infer the catalog partition for
        /// provider calls. Optional; when absent the provider connection defaults to the prod
        /// catalog.
        /// </summary>
        [JsonProperty("project")]
        [STJS.JsonPropertyName("project")]
        public string Project { get; set; }

        /// <summary>
        /// Identifier of the provider to connect to.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Deprecated identifier of the provider to connect to; use <c>provider</c> instead.
        /// </summary>
        [JsonProperty("provider_name")]
        [STJS.JsonPropertyName("provider_name")]
        public string ProviderName { get; set; }
    }
}
