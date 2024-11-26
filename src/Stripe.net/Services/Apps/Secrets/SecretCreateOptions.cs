// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SecretCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Unix timestamp for the expiry time of the secret, after which the secret deletes.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// A name for the secret that's unique within the scope.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The plaintext secret value to be stored.
        /// </summary>
        [JsonProperty("payload")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payload")]
#endif
        public string Payload { get; set; }

        /// <summary>
        /// Specifies the scoping of the secret. Requests originating from UI extensions can only
        /// access account-scoped secrets or secrets scoped to their own user.
        /// </summary>
        [JsonProperty("scope")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("scope")]
#endif
        public SecretScopeOptions Scope { get; set; }
    }
}
