// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ClaimableSandboxSandboxDetails : StripeEntity<ClaimableSandboxSandboxDetails>
    {
        /// <summary>
        /// The sandbox's Stripe account ID.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// Keys that can be used to set up an integration for this sandbox and operate on the
        /// account. This will be present only in the create response, and will be null in
        /// subsequent retrieve responses.
        /// </summary>
        [JsonProperty("api_keys")]
        [STJS.JsonPropertyName("api_keys")]
        public ClaimableSandboxSandboxDetailsApiKeys ApiKeys { get; set; }
    }
}
