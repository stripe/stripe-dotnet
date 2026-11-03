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
        /// account. Present in the create response. To fetch this field in the retrieve response,
        /// pass <c>sandbox_details.api_keys</c> in the <c>include</c> parameter.
        /// </summary>
        [JsonProperty("api_keys")]
        [STJS.JsonPropertyName("api_keys")]
        public ClaimableSandboxSandboxDetailsApiKeys ApiKeys { get; set; }
    }
}
