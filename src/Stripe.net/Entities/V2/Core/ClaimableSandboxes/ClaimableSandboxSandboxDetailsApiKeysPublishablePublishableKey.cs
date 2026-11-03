// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandboxSandboxDetailsApiKeysPublishablePublishableKey : StripeEntity<ClaimableSandboxSandboxDetailsApiKeysPublishablePublishableKey>
    {
        /// <summary>
        /// The plaintext token for the API key.
        /// </summary>
        [JsonProperty("token")]
        [STJS.JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
