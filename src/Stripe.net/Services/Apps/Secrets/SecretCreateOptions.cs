// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using Newtonsoft.Json;

    public class SecretCreateOptions : BaseOptions
    {
        /// <summary>
        /// A name for the secret that's unique within the scope.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The plaintext secret value to be stored.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }

        /// <summary>
        /// Specifies the scoping of the secret. Requests originating from UI extensions can only
        /// access account-scoped secrets or secrets scoped to their own user.
        /// </summary>
        [JsonProperty("scope")]
        public SecretScopeOptions Scope { get; set; }
    }
}
