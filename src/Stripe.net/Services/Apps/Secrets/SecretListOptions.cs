// File generated from our OpenAPI spec
namespace Stripe.Apps
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SecretListOptions : ListOptions
    {
        /// <summary>
        /// Specifies the scoping of the secret. Requests originating from UI extensions can only
        /// access account-scoped secrets or secrets scoped to their own user.
        /// </summary>
        [JsonProperty("scope")]
        [STJS.JsonPropertyName("scope")]
        public SecretScopeOptions Scope { get; set; }
    }
}
