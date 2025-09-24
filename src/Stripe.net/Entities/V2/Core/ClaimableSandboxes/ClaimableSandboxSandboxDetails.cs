// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ClaimableSandboxSandboxDetails : StripeEntity<ClaimableSandboxSandboxDetails>
    {
        /// <summary>
        /// The sandbox's Stripe account ID.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// Keys that can be used to set up an integration for this sandbox and operate on the
        /// account. This will be present only in the create response, and will be null in
        /// subsequent retrieve responses.
        /// </summary>
        [JsonProperty("api_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("api_keys")]
#endif
        public ClaimableSandboxSandboxDetailsApiKeys ApiKeys { get; set; }

        /// <summary>
        /// The livemode sandbox Stripe account ID. This field is only set if the user activates
        /// their sandbox and chooses to install your platform's Stripe App in their live account.
        /// </summary>
        [JsonProperty("owner_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("owner_account")]
#endif
        public string OwnerAccount { get; set; }
    }
}
